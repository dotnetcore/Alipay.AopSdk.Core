

using System;
using System.IO;
using System.Security.Cryptography;
using Alipay.AopSdk.Core;
using Microsoft.Extensions.Options;

namespace Alipay.AopSdk.AspnetCore
{
	public class AlipayConfigChecker
	{
		public static void Check(string signType,string privateKey)
		{
			//SignType私钥检查
			if (string.IsNullOrEmpty(signType))
			{
				throw new Exception("您的支付宝配置未能通过检查，详细信息：签名类型未指定！");
			}

			//RSA私钥检查
			if (string.IsNullOrEmpty(privateKey))
			{
				throw new Exception("您的支付宝配置未能通过检查，详细信息：未能获取到商户私钥！");
			}

			try
			{
				//RSA私钥格式检查
				RSA rsaCsp = LoadCertificateString(privateKey, signType);

				if (rsaCsp == null)
				{
					throw new Exception("您的支付宝配置未能通过检查，详细信息：商户私钥格式错误，未能导入！");
				}
			}
			catch (Exception e)
			{
				throw new Exception("您的支付宝配置未能通过检查，详细信息：商户私钥格式错误，未能导入！",e);
			}

		}

		private static RSA LoadCertificateString(string strKey, string signType)
		{
			byte[] data = null;
			//读取带
			//ata = Encoding.Default.GetBytes(strKey);
			data = Convert.FromBase64String(strKey);
			//data = GetPem("RSA PRIVATE KEY", data);
			try
			{
				var rsa = DecodeRsaPrivateKey(data, signType);
				return rsa;
			}
			catch (Exception ex)
			{
				throw new AopException("Alipay.AopSdk.Core.Util.AlipaySignature LoadCertificateString DecodeRSAPrivateKey Error", ex);
			}
		}

		private static RSA DecodeRsaPrivateKey(byte[] privkey, string signType)
		{
			byte[] MODULUS, E, D, P, Q, DP, DQ, IQ;

			// --------- Set up stream to decode the asn.1 encoded RSA private key ------
			var mem = new MemoryStream(privkey);
			var binr = new BinaryReader(mem); //wrap Memory Stream with BinaryReader for easy reading
			byte bt = 0;
			ushort twobytes = 0;
			var elems = 0;
			try
			{
				twobytes = binr.ReadUInt16();
				if (twobytes == 0x8130) //data read as little endian order (actual data order for Sequence is 30 81)
					binr.ReadByte(); //advance 1 byte
				else if (twobytes == 0x8230)
					binr.ReadInt16(); //advance 2 bytes
				else
					return null;

				twobytes = binr.ReadUInt16();
				if (twobytes != 0x0102) //version number
					return null;
				bt = binr.ReadByte();
				if (bt != 0x00)
					return null;


				//------ all private key components are Integer sequences ----
				elems = GetIntegerSize(binr);
				MODULUS = binr.ReadBytes(elems);

				elems = GetIntegerSize(binr);
				E = binr.ReadBytes(elems);

				elems = GetIntegerSize(binr);
				D = binr.ReadBytes(elems);

				elems = GetIntegerSize(binr);
				P = binr.ReadBytes(elems);

				elems = GetIntegerSize(binr);
				Q = binr.ReadBytes(elems);

				elems = GetIntegerSize(binr);
				DP = binr.ReadBytes(elems);

				elems = GetIntegerSize(binr);
				DQ = binr.ReadBytes(elems);

				elems = GetIntegerSize(binr);
				IQ = binr.ReadBytes(elems);


				// ------- create RSACryptoServiceProvider instance and initialize with public key -----
				var CspParameters = new CspParameters();
				CspParameters.Flags = CspProviderFlags.UseMachineKeyStore;

				var bitLen = 1024;
				if ("RSA2".Equals(signType))
					bitLen = 2048;

				var rsa = RSA.Create();
				rsa.KeySize = bitLen;
				var rsAparams = new RSAParameters();
				rsAparams.Modulus = MODULUS;
				rsAparams.Exponent = E;
				rsAparams.D = D;
				rsAparams.P = P;
				rsAparams.Q = Q;
				rsAparams.DP = DP;
				rsAparams.DQ = DQ;
				rsAparams.InverseQ = IQ;
				rsa.ImportParameters(rsAparams);
				return rsa;
			}
			catch (Exception ex)
			{
				return null;
			}
			finally
			{
				binr.Close();
			}
		}

		private static int GetIntegerSize(BinaryReader binr)
		{
			byte bt = 0;
			byte lowbyte = 0x00;
			byte highbyte = 0x00;
			var count = 0;
			bt = binr.ReadByte();
			if (bt != 0x02) //expect integer
				return 0;
			bt = binr.ReadByte();

			if (bt == 0x81)
			{
				count = binr.ReadByte(); // data size in next byte
			}
			else if (bt == 0x82)
			{
				highbyte = binr.ReadByte(); // data size in next 2 bytes
				lowbyte = binr.ReadByte();
				byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };
				count = BitConverter.ToInt32(modint, 0);
			}
			else
			{
				count = bt; // we already have the data size
			}

			while (binr.ReadByte() == 0x00)
				//remove high order zeros in data
				count -= 1;
			binr.BaseStream.Seek(-1, SeekOrigin.Current); //last ReadByte wasn't a removed zero, so back up a byte
			return count;
		}
	}
}