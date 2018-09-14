using System;
using System.Security.Cryptography;
using Alipay.AopSdk.Core.Domain;
using Alipay.AopSdk.Core.Util;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Alipay.AopSdk.AspnetCore
{
	public class AlipayOptions
	{
		/// <summary>
		///  应用ID,您的APPID
		/// </summary>
		public string AppId { get; set; }

		/// <summary>
		/// 合作商户uid
		/// </summary>
		public string Uid { get; set; }

		/// <summary>
		/// 支付宝网关
		/// </summary>
		public string Gatewayurl { get; set; }

		/// <summary>
		/// 商户私钥，您的原始格式RSA私钥
		/// </summary>
		public string PrivateKey { get; set; }

		/// <summary>
		/// 支付宝公钥,查看地址：https://openhome.alipay.com/platform/keyManage.htm 对应APPID下的支付宝公钥。
		/// </summary>
		public string AlipayPublicKey { get; set; }

		/// <summary>
		/// 签名方式
		/// </summary>
		public string SignType { get; set; } = "RSA2";

		/// <summary>
		/// 编码格式
		/// </summary>
		public string CharSet { get; set; } = "UTF-8";

		/// <summary>
		/// 是否从文件读取公私钥 如果为true ，那么公私钥应该配置为密钥文件路径
		/// </summary>
		public bool IsKeyFromFile { get; set; } = false;

	    public void SetOption(IConfigurationSection section)
	    {
	        if (section == null)
	        {
	            throw new ArgumentException(nameof(section));
	        }

	        var options = section.Get<AlipayOptions>();
	        SetOption(options);
        }

	    public void SetOption(AlipayOptions options)
	    {
	        if (options == null)
	        {
	            throw new ArgumentException(nameof(options));
	        }

	        //SignType私钥检查
	        if (string.IsNullOrEmpty(options.SignType))
	        {
	            throw new Exception("您的支付宝配置未能通过检查，详细信息：签名类型未指定！");
	        }

	        //RSA私钥检查
	        if (string.IsNullOrEmpty(options.PrivateKey))
	        {
	            throw new Exception("您的支付宝配置未能通过检查，详细信息：未能获取到商户私钥！");
	        }

	        //RSA私钥格式检查
	        RSA rsaCsp = AlipaySignature.LoadCertificateString(options.PrivateKey, options.SignType);

	        if (rsaCsp == null)
	        {
	            throw new Exception("您的支付宝配置未能通过检查，详细信息：商户私钥格式错误，未能导入！");
	        }

            this.Uid = options.Uid;
	        this.AlipayPublicKey = options.AlipayPublicKey;
	        this.AppId = options.AppId;
	        this.CharSet = options.CharSet;
	        this.Gatewayurl = options.Gatewayurl;
	        this.PrivateKey = options.PrivateKey;
	        this.SignType = options.SignType;
        }

    }
}