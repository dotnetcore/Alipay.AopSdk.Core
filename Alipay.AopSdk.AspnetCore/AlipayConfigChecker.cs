

using System;
using System.IO;
using System.Security.Cryptography;
using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Util;
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

			//RSA私钥格式检查
			RSA rsaCsp = AlipaySignature.LoadCertificateString(privateKey, signType);

			if (rsaCsp == null)
			{
				throw new Exception("您的支付宝配置未能通过检查，详细信息：商户私钥格式错误，未能导入！");
			}

		}
	}
}