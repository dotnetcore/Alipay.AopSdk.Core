using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Alipay.AopSdk.Core.Util
{
	public class AlipaySignature
	{
		/** 默认编码字符集 */
		private static readonly string DEFAULT_CHARSET = "GBK";

		public static string GetSignContent(IDictionary<string, string> parameters)
		{
			// 第一步：把字典按Key的字母顺序排序
			IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters);
			var dem = sortedParams.GetEnumerator();

			// 第二步：把所有参数名和参数值串在一起
			var query = new StringBuilder("");
			while (dem.MoveNext())
			{
				var key = dem.Current.Key;
				var value = dem.Current.Value;
				if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
					query.Append(key).Append("=").Append(value).Append("&");
			}
			var content = query.ToString().Substring(0, query.Length - 1);

			return content;
		}

		public static string RSASign(IDictionary<string, string> parameters, string privateKeyPem, string charset,
			string signType)
		{
			var signContent = GetSignContent(parameters);

			return RSASignCharSet(signContent, privateKeyPem, charset, signType);
		}

		public static string RSASign(string data, string privateKeyPem, string charset, string signType)
		{
			return RSASignCharSet(data, privateKeyPem, charset, signType);
		}

		///*
		public static string RSASign(IDictionary<string, string> parameters, string privateKeyPem, string charset,
			bool keyFromFile, string signType)
		{
			var signContent = GetSignContent(parameters);

			return RSASignCharSet(signContent, privateKeyPem, charset, keyFromFile, signType);
		}

		public static string RSASign(string data, string privateKeyPem, string charset, string signType, bool keyFromFile)
		{
			return RSASignCharSet(data, privateKeyPem, charset, keyFromFile, signType);
		}

		//*/
		public static string RSASignCharSet(string data, string privateKeyPem, string charset, string signType)
		{
			RSA rsaCsp = LoadCertificateFile(privateKeyPem, signType);
			byte[] dataBytes = null;
			if (string.IsNullOrEmpty(charset))
				dataBytes = Encoding.UTF8.GetBytes(data);
			else
				dataBytes = Encoding.GetEncoding(charset).GetBytes(data);

			var signatureBytes = rsaCsp.SignData(dataBytes, "RSA2".Equals(signType) ? HashAlgorithmName.SHA256 : HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

			return Convert.ToBase64String(signatureBytes);
		}


		public static string RSASignCharSet(string data, string privateKeyPem, string charset, bool keyFromFile,
			string signType)
		{
			byte[] signatureBytes = null;
			try
			{
				RSA rsaCsp = null;
				rsaCsp = keyFromFile ? LoadCertificateFile(privateKeyPem, signType) : LoadCertificateString(privateKeyPem, signType);

				byte[] dataBytes = null;
				if (string.IsNullOrEmpty(charset))
					dataBytes = Encoding.UTF8.GetBytes(data);
				else
					dataBytes = Encoding.GetEncoding(charset).GetBytes(data);
				if (null == rsaCsp)
					throw new AopException("您使用的私钥格式错误，请检查RSA私钥配置" + ",charset = " + charset);
				signatureBytes = rsaCsp.SignData(dataBytes, "RSA2".Equals(signType) ? HashAlgorithmName.SHA256 : HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
			}
			catch (Exception ex)
			{
				throw new AopException("您使用的私钥格式错误，请检查RSA私钥配置" + ",charset = " + charset, ex);
			}
			return Convert.ToBase64String(signatureBytes);
		}


		public static bool RSACheckV1(IDictionary<string, string> parameters, string publicKeyPem, string charset)
		{
			var sign = parameters["sign"];

			parameters.Remove("sign");
			parameters.Remove("sign_type");
			var signContent = GetSignContent(parameters);
			return RSACheckContent(signContent, sign, publicKeyPem, charset, "RSA");
		}

		public static bool RSACheckV1(IDictionary<string, string> parameters, string publicKeyPem)
		{
			var sign = parameters["sign"];

			parameters.Remove("sign");
			parameters.Remove("sign_type");
			var signContent = GetSignContent(parameters);

			return RSACheckContent(signContent, sign, publicKeyPem, DEFAULT_CHARSET, "RSA");
		}

		public static bool RSACheckV1(IDictionary<string, string> parameters, string publicKeyPem, string charset,
			string signType, bool keyFromFile)
		{
			var sign = parameters["sign"];

			parameters.Remove("sign");
			parameters.Remove("sign_type");
			var signContent = GetSignContent(parameters);
			return RSACheckContent(signContent, sign, publicKeyPem, charset, signType, keyFromFile);
		}

		public static bool RSACheckV2(IDictionary<string, string> parameters, string publicKeyPem)
		{
			var sign = parameters["sign"];

			parameters.Remove("sign");
			var signContent = GetSignContent(parameters);

			return RSACheckContent(signContent, sign, publicKeyPem, DEFAULT_CHARSET, "RSA");
		}

		public static bool RSACheckV2(IDictionary<string, string> parameters, string publicKeyPem, string charset)
		{
			var sign = parameters["sign"];

			parameters.Remove("sign");
			var signContent = GetSignContent(parameters);

			return RSACheckContent(signContent, sign, publicKeyPem, charset, "RSA");
		}

		public static bool RSACheckV2(IDictionary<string, string> parameters, string publicKeyPem, string charset,
			string signType, bool keyFromFile)
		{
			var sign = parameters["sign"];

			parameters.Remove("sign");
			var signContent = GetSignContent(parameters);

			return RSACheckContent(signContent, sign, publicKeyPem, charset, signType, keyFromFile);
		}

		public static RSA CreateRsaProviderFromPublicKey(string publicKeyString,string signType)
		{
			// encoded OID sequence for  PKCS #1 rsaEncryption szOID_RSA_RSA = "1.2.840.113549.1.1.1"
			byte[] seqOid = { 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, 0x05, 0x00 };
			byte[] seq = new byte[15];

			var x509Key = Convert.FromBase64String(publicKeyString);

			// ---------  Set up stream to read the asn.1 encoded SubjectPublicKeyInfo blob  ------
			using (MemoryStream mem = new MemoryStream(x509Key))
			{
				using (BinaryReader binr = new BinaryReader(mem))  //wrap Memory Stream with BinaryReader for easy reading
				{
					byte bt = 0;
					ushort twobytes = 0;

					twobytes = binr.ReadUInt16();
					if (twobytes == 0x8130) //data read as little endian order (actual data order for Sequence is 30 81)
						binr.ReadByte();    //advance 1 byte
					else if (twobytes == 0x8230)
						binr.ReadInt16();   //advance 2 bytes
					else
						return null;

					seq = binr.ReadBytes(15);       //read the Sequence OID
					if (!CompareBytearrays(seq, seqOid))    //make sure Sequence for OID is correct
						return null;

					twobytes = binr.ReadUInt16();
					if (twobytes == 0x8103) //data read as little endian order (actual data order for Bit String is 03 81)
						binr.ReadByte();    //advance 1 byte
					else if (twobytes == 0x8203)
						binr.ReadInt16();   //advance 2 bytes
					else
						return null;

					bt = binr.ReadByte();
					if (bt != 0x00)     //expect null byte next
						return null;

					twobytes = binr.ReadUInt16();
					if (twobytes == 0x8130) //data read as little endian order (actual data order for Sequence is 30 81)
						binr.ReadByte();    //advance 1 byte
					else if (twobytes == 0x8230)
						binr.ReadInt16();   //advance 2 bytes
					else
						return null;

					twobytes = binr.ReadUInt16();
					byte lowbyte = 0x00;
					byte highbyte = 0x00;

					if (twobytes == 0x8102) //data read as little endian order (actual data order for Integer is 02 81)
						lowbyte = binr.ReadByte();  // read next bytes which is bytes in modulus
					else if (twobytes == 0x8202)
					{
						highbyte = binr.ReadByte(); //advance 2 bytes
						lowbyte = binr.ReadByte();
					}
					else
						return null;
					byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };   //reverse byte order since asn.1 key uses big endian order
					int modsize = BitConverter.ToInt32(modint, 0);

					int firstbyte = binr.PeekChar();
					if (firstbyte == 0x00)
					{   //if first byte (highest order) of modulus is zero, don't include it
						binr.ReadByte();    //skip this null byte
						modsize -= 1;   //reduce modulus buffer size by 1
					}

					byte[] modulus = binr.ReadBytes(modsize);   //read the modulus bytes

					if (binr.ReadByte() != 0x02)            //expect an Integer for the exponent data
						return null;
					int expbytes = (int)binr.ReadByte();        // should only need one byte for actual exponent data (for all useful values)
					byte[] exponent = binr.ReadBytes(expbytes);

					// ------- create RSACryptoServiceProvider instance and initialize with public key -----
					var rsa = RSA.Create();
					rsa.KeySize = signType == "RSA" ? 1024 : 2048;
					RSAParameters rsaKeyInfo = new RSAParameters();
					rsaKeyInfo.Modulus = modulus;
					rsaKeyInfo.Exponent = exponent;
					rsa.ImportParameters(rsaKeyInfo);

					return rsa;
				}

			}
		}

		private static bool CompareBytearrays(byte[] a, byte[] b)
		{
			if (a.Length != b.Length)
				return false;
			int i = 0;
			foreach (byte c in a)
			{
				if (c != b[i])
					return false;
				i++;
			}
			return true;
		}

		public static bool RSACheckContent(string signContent, string sign, string publicKeyPem, string charset,
			string signType)
		{
			try
			{
				if (string.IsNullOrEmpty(charset))
					charset = DEFAULT_CHARSET;

				var sPublicKeyPem = File.ReadAllText(publicKeyPem);

				var rsa = CreateRsaProviderFromPublicKey(sPublicKeyPem, signType);

				if ("RSA2".Equals(signType))
				{
					

					var bVerifyResultOriginal = rsa.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent),
						Convert.FromBase64String(sign),HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
					return bVerifyResultOriginal;
				}
				else
				{
					
					var bVerifyResultOriginal = rsa.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent),
						Convert.FromBase64String(sign), HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
					return bVerifyResultOriginal;
				}
			}
			catch
			{
				return false;
			}
		}

		public static bool RSACheckContent(string signContent, string sign, string publicKeyPem, string charset,
			string signType, bool keyFromFile)
		{
			try
			{
				if (string.IsNullOrEmpty(charset))
					charset = DEFAULT_CHARSET;

				string sPublicKeyPem= publicKeyPem;

				if (keyFromFile)
				{
					sPublicKeyPem = File.ReadAllText(publicKeyPem);
				}
				var rsa = CreateRsaProviderFromPublicKey(sPublicKeyPem, signType);

				if ("RSA2".Equals(signType))
				{
					

					var bVerifyResultOriginal = rsa.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent),
						Convert.FromBase64String(sign), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
					return bVerifyResultOriginal;
				}
				else
				{
					var bVerifyResultOriginal = rsa.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent),
						Convert.FromBase64String(sign), HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
					return bVerifyResultOriginal;
				}
			}
			catch
			{
				return false;
			}
		}

		public static bool RSACheckContent(string signContent, string sign, string publicKeyPem, string charset,
			bool keyFromFile)
		{
			try
			{
				string sPublicKeyPem= publicKeyPem;
				if (keyFromFile)
				{
					sPublicKeyPem = File.ReadAllText(publicKeyPem);
				}
				var rsa = CreateRsaProviderFromPublicKey(sPublicKeyPem, "RSA");
				var sha1 = new SHA1CryptoServiceProvider();
				if (string.IsNullOrEmpty(charset))
					charset = DEFAULT_CHARSET;
				var bVerifyResultOriginal = rsa.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent),
					Convert.FromBase64String(sign),HashAlgorithmName.SHA1,RSASignaturePadding.Pkcs1);
				return bVerifyResultOriginal;
			}
			catch (Exception ex)
			{
				var s = ex.Message;
				return false;
			}
		}

		public static string CheckSignAndDecrypt(IDictionary<string, string> parameters, string alipayPublicKey,
			string cusPrivateKey, bool isCheckSign,
			bool isDecrypt)
		{
			var charset = parameters["charset"];
			var bizContent = parameters["biz_content"];
			if (isCheckSign)
				if (!RSACheckV2(parameters, alipayPublicKey, charset))
					throw new AopException("rsaCheck failure:rsaParams=" + parameters);

			if (isDecrypt)
				return RSADecrypt(bizContent, cusPrivateKey, charset, "RSA");

			return bizContent;
		}

		public static string CheckSignAndDecrypt(IDictionary<string, string> parameters, string alipayPublicKey,
			string cusPrivateKey, bool isCheckSign,
			bool isDecrypt, string signType, bool keyFromFile)
		{
			var charset = parameters["charset"];
			var bizContent = parameters["biz_content"];
			if (isCheckSign)
				if (!RSACheckV2(parameters, alipayPublicKey, charset, signType, keyFromFile))
					throw new AopException("rsaCheck failure:rsaParams=" + parameters);

			if (isDecrypt)
				return RSADecrypt(bizContent, cusPrivateKey, charset, signType, keyFromFile);

			return bizContent;
		}

		public static string encryptAndSign(string bizContent, string alipayPublicKey,
			string cusPrivateKey, string charset, bool isEncrypt,
			bool isSign, string signType, bool keyFromFile)
		{
			var sb = new StringBuilder();
			if (string.IsNullOrEmpty(charset))
				charset = DEFAULT_CHARSET;
			sb.Append("<?xml version=\"1.0\" encoding=\"" + charset + "\"?>");
			if (isEncrypt)
			{
// 加密
				sb.Append("<alipay>");
				var encrypted = RSAEncrypt(bizContent, alipayPublicKey, charset, keyFromFile);
				sb.Append("<response>" + encrypted + "</response>");
				sb.Append("<encryption_type>" + signType + "</encryption_type>");
				if (isSign)
				{
					var sign = RSASign(encrypted, cusPrivateKey, charset, signType, keyFromFile);
					sb.Append("<sign>" + sign + "</sign>");
					sb.Append("<sign_type>" + signType + "</sign_type>");
				}
				sb.Append("</alipay>");
			}
			else if (isSign)
			{
// 不加密，但需要签名
				sb.Append("<alipay>");
				sb.Append("<response>" + bizContent + "</response>");
				var sign = RSASign(bizContent, cusPrivateKey, charset, signType, keyFromFile);
				sb.Append("<sign>" + sign + "</sign>");
				sb.Append("<sign_type>" + signType + "</sign_type>");
				sb.Append("</alipay>");
			}
			else
			{
// 不加密，不加签
				sb.Append(bizContent);
			}
			return sb.ToString();
		}

		public static string encryptAndSign(string bizContent, string alipayPublicKey,
			string cusPrivateKey, string charset, bool isEncrypt,
			bool isSign)
		{
			var sb = new StringBuilder();
			if (string.IsNullOrEmpty(charset))
				charset = DEFAULT_CHARSET;
			sb.Append("<?xml version=\"1.0\" encoding=\"" + charset + "\"?>");
			if (isEncrypt)
			{
// 加密
				sb.Append("<alipay>");
				var encrypted = RSAEncrypt(bizContent, alipayPublicKey, charset);
				sb.Append("<response>" + encrypted + "</response>");
				sb.Append("<encryption_type>RSA</encryption_type>");
				if (isSign)
				{
					var sign = RSASign(encrypted, cusPrivateKey, charset, "RSA");
					sb.Append("<sign>" + sign + "</sign>");
					sb.Append("<sign_type>RSA</sign_type>");
				}
				sb.Append("</alipay>");
			}
			else if (isSign)
			{
// 不加密，但需要签名
				sb.Append("<alipay>");
				sb.Append("<response>" + bizContent + "</response>");
				var sign = RSASign(bizContent, cusPrivateKey, charset, "RSA");
				sb.Append("<sign>" + sign + "</sign>");
				sb.Append("<sign_type>RSA</sign_type>");
				sb.Append("</alipay>");
			}
			else
			{
// 不加密，不加签
				sb.Append(bizContent);
			}
			return sb.ToString();
		}

		public static string RSAEncrypt(string content, string publicKeyPem, string charset)
		{
			try
			{
				var sPublicKeyPEM = File.ReadAllText(publicKeyPem);
				var rsa = CreateRsaProviderFromPublicKey(sPublicKeyPEM, "RSA");
				if (string.IsNullOrEmpty(charset))
					charset = DEFAULT_CHARSET;
				var data = Encoding.GetEncoding(charset).GetBytes(content);
				var maxBlockSize = rsa.KeySize / 8 - 11; //加密块最大长度限制
				if (data.Length <= maxBlockSize)
				{
					var cipherbytes = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
					return Convert.ToBase64String(cipherbytes);
				}
				var plaiStream = new MemoryStream(data);
				var crypStream = new MemoryStream();
				var buffer = new byte[maxBlockSize];
				var blockSize = plaiStream.Read(buffer, 0, maxBlockSize);
				while (blockSize > 0)
				{
					var toEncrypt = new byte[blockSize];
					Array.Copy(buffer, 0, toEncrypt, 0, blockSize);
					var cryptograph = rsa.Encrypt(toEncrypt, RSAEncryptionPadding.Pkcs1);
					crypStream.Write(cryptograph, 0, cryptograph.Length);
					blockSize = plaiStream.Read(buffer, 0, maxBlockSize);
				}

				return Convert.ToBase64String(crypStream.ToArray(), Base64FormattingOptions.None);
			}
			catch (Exception ex)
			{
				throw new AopException("EncryptContent = " + content + ",charset = " + charset, ex);
			}
		}

		public static string RSAEncrypt(string content, string publicKeyPem, string charset, bool keyFromFile)
		{
			try
			{
				string sPublicKeyPEM= publicKeyPem;
				if (keyFromFile)
				{
					sPublicKeyPEM = File.ReadAllText(publicKeyPem);
				}
				var rsa = CreateRsaProviderFromPublicKey(publicKeyPem, "RSA");
				if (string.IsNullOrEmpty(charset))
					charset = DEFAULT_CHARSET;
				var data = Encoding.GetEncoding(charset).GetBytes(content);
				var maxBlockSize = rsa.KeySize / 8 - 11; //加密块最大长度限制
				if (data.Length <= maxBlockSize)
				{
					var cipherbytes = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
					return Convert.ToBase64String(cipherbytes);
				}
				var plaiStream = new MemoryStream(data);
				var crypStream = new MemoryStream();
				var buffer = new byte[maxBlockSize];
				var blockSize = plaiStream.Read(buffer, 0, maxBlockSize);
				while (blockSize > 0)
				{
					var toEncrypt = new byte[blockSize];
					Array.Copy(buffer, 0, toEncrypt, 0, blockSize);
					var cryptograph = rsa.Encrypt(toEncrypt, RSAEncryptionPadding.Pkcs1);
					crypStream.Write(cryptograph, 0, cryptograph.Length);
					blockSize = plaiStream.Read(buffer, 0, maxBlockSize);
				}

				return Convert.ToBase64String(crypStream.ToArray(), Base64FormattingOptions.None);
			}
			catch (Exception ex)
			{
				throw new AopException("EncryptContent = " + content + ",charset = " + charset, ex);
			}
		}

		public static string RSADecrypt(string content, string privateKeyPem, string charset, string signType)
		{
			try
			{
				var rsaCsp = LoadCertificateFile(privateKeyPem, signType);
				if (string.IsNullOrEmpty(charset))
					charset = DEFAULT_CHARSET;
				var data = Convert.FromBase64String(content);
				var maxBlockSize = rsaCsp.KeySize / 8; //解密块最大长度限制
				if (data.Length <= maxBlockSize)
				{
					var cipherbytes = rsaCsp.Decrypt(data, RSAEncryptionPadding.Pkcs1);
					return Encoding.GetEncoding(charset).GetString(cipherbytes);
				}
				var crypStream = new MemoryStream(data);
				var plaiStream = new MemoryStream();
				var buffer = new byte[maxBlockSize];
				var blockSize = crypStream.Read(buffer, 0, maxBlockSize);
				while (blockSize > 0)
				{
					var toDecrypt = new byte[blockSize];
					Array.Copy(buffer, 0, toDecrypt, 0, blockSize);
					var cryptograph = rsaCsp.Decrypt(toDecrypt, RSAEncryptionPadding.Pkcs1);
					plaiStream.Write(cryptograph, 0, cryptograph.Length);
					blockSize = crypStream.Read(buffer, 0, maxBlockSize);
				}

				return Encoding.GetEncoding(charset).GetString(plaiStream.ToArray());
			}
			catch (Exception ex)
			{
				throw new AopException("DecryptContent = " + content + ",charset = " + charset, ex);
			}
		}

		public static string RSADecrypt(string content, string privateKeyPem, string charset, string signType,
			bool keyFromFile)
		{
			try
			{
				RSA rsaCsp = null;
				if (keyFromFile)
					rsaCsp = LoadCertificateFile(privateKeyPem, signType);
				else
					rsaCsp = LoadCertificateString(privateKeyPem, signType);
				if (string.IsNullOrEmpty(charset))
					charset = DEFAULT_CHARSET;
				var data = Convert.FromBase64String(content);
				var maxBlockSize = rsaCsp.KeySize / 8; //解密块最大长度限制
				if (data.Length <= maxBlockSize)
				{
					var cipherbytes = rsaCsp.Decrypt(data, RSAEncryptionPadding.Pkcs1);
					return Encoding.GetEncoding(charset).GetString(cipherbytes);
				}
				var crypStream = new MemoryStream(data);
				var plaiStream = new MemoryStream();
				var buffer = new byte[maxBlockSize];
				var blockSize = crypStream.Read(buffer, 0, maxBlockSize);
				while (blockSize > 0)
				{
					var toDecrypt = new byte[blockSize];
					Array.Copy(buffer, 0, toDecrypt, 0, blockSize);
					var cryptograph = rsaCsp.Decrypt(toDecrypt, RSAEncryptionPadding.Pkcs1);
					plaiStream.Write(cryptograph, 0, cryptograph.Length);
					blockSize = crypStream.Read(buffer, 0, maxBlockSize);
				}

				return Encoding.GetEncoding(charset).GetString(plaiStream.ToArray());
			}
			catch (Exception ex)
			{
				throw new AopException("DecryptContent = " + content + ",charset = " + charset, ex);
			}
		}

		private static byte[] GetPem(string type, byte[] data)
		{
			var pem = Encoding.UTF8.GetString(data);
			var header = string.Format("-----BEGIN {0}-----\\n", type);
			var footer = string.Format("-----END {0}-----", type);
			var start = pem.IndexOf(header) + header.Length;
			var end = pem.IndexOf(footer, start);
			var base64 = pem.Substring(start, end - start);

			return Convert.FromBase64String(base64);
		}

		private static RSA LoadCertificateFile(string filename, string signType)
		{
			using (var fs = File.OpenRead(filename))
			{
				var data = new byte[fs.Length];
				byte[] res = null;
				fs.Read(data, 0, data.Length);
				if (data[0] != 0x30)
					res = GetPem("RSA PRIVATE KEY", data);
				try
				{
					var rsa = DecodeRSAPrivateKey(res, signType);
					return rsa;
				}
				catch (Exception ex)
				{
				}
				return null;
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
				var rsa = DecodeRSAPrivateKey(data, signType);
				return rsa;
			}
			catch (Exception ex)
			{
				//    throw new AopException("EncryptContent = woshihaoren,zheshiyigeceshi,wanerde", ex);
			}
			return null;
		}

		private static RSA DecodeRSAPrivateKey(byte[] privkey, string signType)
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
				byte[] modint = {lowbyte, highbyte, 0x00, 0x00};
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