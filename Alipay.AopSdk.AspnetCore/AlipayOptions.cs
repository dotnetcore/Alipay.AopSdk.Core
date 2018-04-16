using System;
using Alipay.AopSdk.Core.Domain;
using Microsoft.Extensions.Options;

namespace Alipay.AopSdk.AspnetCore
{
	public class AlipayOptions : IOptions<AlipayOptions>
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

		
		private string _privateKey;
		/// <summary>
		/// 商户私钥，您的原始格式RSA私钥
		/// </summary>
		public string PrivateKey
		{
			get => _privateKey;
			set
			{
				_privateKey = value;
				if (_privateKey == null)
				{
					throw new ArgumentException("参数不得为空", nameof(PrivateKey));
				}
				if (!string.IsNullOrEmpty(_privateKey))
				{
					AlipayConfigChecker.Check(this);
				}
			}
		}

		/// <summary>
		/// 支付宝公钥,查看地址：https://openhome.alipay.com/platform/keyManage.htm 对应APPID下的支付宝公钥。
		/// </summary>
		public string AlipayPublicKey { get; set; }

		
		private string _signType="RSA2";
		/// <summary>
		/// 签名方式
		/// </summary>
		public string SignType
		{
			get => _signType;
			set
			{
				_signType = value;

				if (_signType == null)
				{
					throw new ArgumentException("参数不得为空",nameof(SignType));
				}

				if (!string.IsNullOrEmpty(_privateKey))
				{
					AlipayConfigChecker.Check(this);
				}
			}
		} 

		/// <summary>
		/// 编码格式
		/// </summary>
		public string CharSet { get; set; } = "UTF-8";

		/// <summary>
		/// 是否从文件读取公私钥 如果为true ，那么公私钥应该配置为密钥文件路径
		/// </summary>
		public bool IsKeyFromFile { get; set; } = false;

		AlipayOptions IOptions<AlipayOptions>.Value => this;
	}
}