using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Alipay.AopSdk.Core.Util
{
	public static class RSACryptoServiceProviderExtension
	{
		#region Methods

		/// <summary>Extension method which initializes an RSACryptoServiceProvider from a DER public key blob.</summary>
		public static void LoadPublicKeyDER(RSACryptoServiceProvider provider, byte[] DERData)
		{
			var RSAData = GetRSAFromDER(DERData);
			var publicKeyBlob = GetPublicKeyBlobFromRSA(RSAData);
			provider.ImportCspBlob(publicKeyBlob);
		}

		/// <summary>Extension method which initializes an RSACryptoServiceProvider from a PEM public key string.</summary>
		public static void LoadPublicKeyPEM(RSACryptoServiceProvider provider, string sPEM)
		{
			var DERData = GetDERFromPEM(sPEM);
			LoadPublicKeyDER(provider, DERData);
		}

		/// <summary>Returns a public key blob from an RSA public key.</summary>
		internal static byte[] GetPublicKeyBlobFromRSA(byte[] RSAData)
		{
			byte[] data = null;
			uint dwCertPublicKeyBlobSize = 0;
			if (CryptDecodeObject(CRYPT_ENCODING_FLAGS.X509_ASN_ENCODING | CRYPT_ENCODING_FLAGS.PKCS_7_ASN_ENCODING,
				new IntPtr((int) CRYPT_OUTPUT_TYPES.RSA_CSP_PUBLICKEYBLOB), RSAData, (uint) RSAData.Length, CRYPT_DECODE_FLAGS.NONE,
				data, ref dwCertPublicKeyBlobSize))
			{
				data = new byte[dwCertPublicKeyBlobSize];
				if (!CryptDecodeObject(CRYPT_ENCODING_FLAGS.X509_ASN_ENCODING | CRYPT_ENCODING_FLAGS.PKCS_7_ASN_ENCODING,
					new IntPtr((int) CRYPT_OUTPUT_TYPES.RSA_CSP_PUBLICKEYBLOB), RSAData, (uint) RSAData.Length,
					CRYPT_DECODE_FLAGS.NONE,
					data, ref dwCertPublicKeyBlobSize))
					throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			else
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			return data;
		}

		/// <summary>Converts DER binary format to a CAPI CERT_PUBLIC_KEY_INFO structure containing an RSA key.</summary>
		internal static byte[] GetRSAFromDER(byte[] DERData)
		{
			byte[] data = null;
			byte[] publicKey = null;
			CERT_PUBLIC_KEY_INFO info;
			uint dwCertPublicKeyInfoSize = 0;
			var pCertPublicKeyInfo = IntPtr.Zero;
			if (CryptDecodeObject(CRYPT_ENCODING_FLAGS.X509_ASN_ENCODING | CRYPT_ENCODING_FLAGS.PKCS_7_ASN_ENCODING,
				new IntPtr((int) CRYPT_OUTPUT_TYPES.X509_PUBLIC_KEY_INFO),
				DERData, (uint) DERData.Length, CRYPT_DECODE_FLAGS.NONE, data, ref dwCertPublicKeyInfoSize))
			{
				data = new byte[dwCertPublicKeyInfoSize];
				if (CryptDecodeObject(CRYPT_ENCODING_FLAGS.X509_ASN_ENCODING | CRYPT_ENCODING_FLAGS.PKCS_7_ASN_ENCODING,
					new IntPtr((int) CRYPT_OUTPUT_TYPES.X509_PUBLIC_KEY_INFO),
					DERData, (uint) DERData.Length, CRYPT_DECODE_FLAGS.NONE, data, ref dwCertPublicKeyInfoSize))
				{
					var handle = GCHandle.Alloc(data, GCHandleType.Pinned);
					try
					{
						info = (CERT_PUBLIC_KEY_INFO) Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(CERT_PUBLIC_KEY_INFO));
						publicKey = new byte[info.PublicKey.cbData];
						Marshal.Copy(info.PublicKey.pbData, publicKey, 0, publicKey.Length);
					}
					finally
					{
						handle.Free();
					}
				}
				else
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
			}
			else
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			return publicKey;
		}

		/// <summary>Extracts the binary data from a PEM file.</summary>
		internal static byte[] GetDERFromPEM(string sPEM)
		{
			uint dwSkip, dwFlags;
			uint dwBinarySize = 0;

			if (!CryptStringToBinary(sPEM, (uint) sPEM.Length, CRYPT_STRING_FLAGS.CRYPT_STRING_BASE64HEADER, null,
				ref dwBinarySize, out dwSkip, out dwFlags))
				throw new Win32Exception(Marshal.GetLastWin32Error());

			var decodedData = new byte[dwBinarySize];
			if (!CryptStringToBinary(sPEM, (uint) sPEM.Length, CRYPT_STRING_FLAGS.CRYPT_STRING_BASE64HEADER, decodedData,
				ref dwBinarySize, out dwSkip, out dwFlags))
				throw new Win32Exception(Marshal.GetLastWin32Error());
			return decodedData;
		}

		#endregion Methods

		#region P/Invoke Constants

		/// <summary>Enumeration derived from Crypto API.</summary>
		internal enum CRYPT_ACQUIRE_CONTEXT_FLAGS : uint
		{
			CRYPT_NEWKEYSET = 0x8,
			CRYPT_DELETEKEYSET = 0x10,
			CRYPT_MACHINE_KEYSET = 0x20,
			CRYPT_SILENT = 0x40,
			CRYPT_DEFAULT_CONTAINER_OPTIONAL = 0x80,
			CRYPT_VERIFYCONTEXT = 0xF0000000
		}

		/// <summary>Enumeration derived from Crypto API.</summary>
		internal enum CRYPT_PROVIDER_TYPE : uint
		{
			PROV_RSA_FULL = 1
		}

		/// <summary>Enumeration derived from Crypto API.</summary>
		internal enum CRYPT_DECODE_FLAGS : uint
		{
			NONE = 0,
			CRYPT_DECODE_ALLOC_FLAG = 0x8000
		}

		/// <summary>Enumeration derived from Crypto API.</summary>
		internal enum CRYPT_ENCODING_FLAGS : uint
		{
			PKCS_7_ASN_ENCODING = 0x00010000,
			X509_ASN_ENCODING = 0x00000001
		}

		/// <summary>Enumeration derived from Crypto API.</summary>
		internal enum CRYPT_OUTPUT_TYPES
		{
			X509_PUBLIC_KEY_INFO = 8,
			RSA_CSP_PUBLICKEYBLOB = 19,
			PKCS_RSA_PRIVATE_KEY = 43,
			PKCS_PRIVATE_KEY_INFO = 44
		}

		/// <summary>Enumeration derived from Crypto API.</summary>
		internal enum CRYPT_STRING_FLAGS : uint
		{
			CRYPT_STRING_BASE64HEADER = 0,
			CRYPT_STRING_BASE64 = 1,
			CRYPT_STRING_BINARY = 2,
			CRYPT_STRING_BASE64REQUESTHEADER = 3,
			CRYPT_STRING_HEX = 4,
			CRYPT_STRING_HEXASCII = 5,
			CRYPT_STRING_BASE64_ANY = 6,
			CRYPT_STRING_ANY = 7,
			CRYPT_STRING_HEX_ANY = 8,
			CRYPT_STRING_BASE64X509CRLHEADER = 9,
			CRYPT_STRING_HEXADDR = 10,
			CRYPT_STRING_HEXASCIIADDR = 11,
			CRYPT_STRING_HEXRAW = 12,
			CRYPT_STRING_NOCRLF = 0x40000000,
			CRYPT_STRING_NOCR = 0x80000000
		}

		#endregion P/Invoke Constants

		#region P/Invoke Structures

		/// <summary>Structure from Crypto API.</summary>
		[StructLayout(LayoutKind.Sequential)]
		internal struct CRYPT_OBJID_BLOB
		{
			internal uint cbData;
			internal IntPtr pbData;
		}

		/// <summary>Structure from Crypto API.</summary>
		[StructLayout(LayoutKind.Sequential)]
		internal struct CRYPT_ALGORITHM_IDENTIFIER
		{
			internal IntPtr pszObjId;
			internal CRYPT_OBJID_BLOB Parameters;
		}

		/// <summary>Structure from Crypto API.</summary>
		[StructLayout(LayoutKind.Sequential)]
		private struct CRYPT_BIT_BLOB
		{
			internal readonly uint cbData;
			internal readonly IntPtr pbData;
			internal readonly uint cUnusedBits;
		}

		/// <summary>Structure from Crypto API.</summary>
		[StructLayout(LayoutKind.Sequential)]
		private struct CERT_PUBLIC_KEY_INFO
		{
			internal readonly CRYPT_ALGORITHM_IDENTIFIER Algorithm;
			internal CRYPT_BIT_BLOB PublicKey;
		}

		#endregion P/Invoke Structures

		#region P/Invoke Functions

		/// <summary>Function for Crypto API.</summary>
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptDestroyKey(IntPtr hKey);

		/// <summary>Function for Crypto API.</summary>
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptImportKey(IntPtr hProv, byte[] pbKeyData, uint dwDataLen, IntPtr hPubKey,
			uint dwFlags, ref IntPtr hKey);

		/// <summary>Function for Crypto API.</summary>
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptReleaseContext(IntPtr hProv, int dwFlags);

		/// <summary>Function for Crypto API.</summary>
		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptAcquireContext(ref IntPtr hProv, string pszContainer, string pszProvider,
			CRYPT_PROVIDER_TYPE dwProvType, CRYPT_ACQUIRE_CONTEXT_FLAGS dwFlags);

		/// <summary>Function from Crypto API.</summary>
		[DllImport("crypt32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptStringToBinary(string sPEM, uint sPEMLength, CRYPT_STRING_FLAGS dwFlags,
			[Out] byte[] pbBinary, ref uint pcbBinary, out uint pdwSkip, out uint pdwFlags);

		/// <summary>Function from Crypto API.</summary>
		[DllImport("crypt32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptDecodeObjectEx(CRYPT_ENCODING_FLAGS dwCertEncodingType, IntPtr lpszStructType,
			byte[] pbEncoded, uint cbEncoded, CRYPT_DECODE_FLAGS dwFlags, IntPtr pDecodePara, ref byte[] pvStructInfo,
			ref uint pcbStructInfo);

		/// <summary>Function from Crypto API.</summary>
		[DllImport("crypt32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptDecodeObject(CRYPT_ENCODING_FLAGS dwCertEncodingType, IntPtr lpszStructType,
			byte[] pbEncoded, uint cbEncoded, CRYPT_DECODE_FLAGS flags, [In] [Out] byte[] pvStructInfo, ref uint cbStructInfo);

		#endregion P/Invoke Functions
	}
}