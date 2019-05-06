using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ZhimaCustomerEpCertificationInitializeModel Data Structure.
	/// </summary>
	[Serializable]
	public class ZhimaCustomerEpCertificationInitializeModel : AopObject
	{
		/// <summary>
		///     认证场景码，支持的场景码有EP_ALIPAY_ACCOUNT。签约的协议决定了可以使用哪些场景。
		/// </summary>
		[JsonProperty("biz_code")]
		public string BizCode { get; set; }

		/// <summary>
		///     扩展业务参数，暂时没有用到，接口预留
		/// </summary>
		[JsonProperty("ext_biz_param")]
		public string ExtBizParam { get; set; }

		/// <summary>
		///     值为一个json串，无入参时值为"{}"，有入参时必须指定身份类型identity_type，不同的身份类型对应的身份信息不同。 
		///     当前支持的identity_type=EP_CERT_INFO ，身份信息为法人证件三要素与企业证件三要素，如 {"identity_type": "EP_CERT_INFO", "cert_type": "IDENTITY_CARD", "cert_name": "收委", "cert_no":"260104197909275964", "ep_cert_type": "NATIONAL_LEGAL_MERGE", "ep_cert_name": "xxx有限公司", "ep_cert_no":"91330000327827106L"}。 
		///     备注：上述json串中的 ep_cert_type 属性仅支持2种类型： NATIONAL_LEGAL：工商注册号；NATIONAL_LEGAL_MERGE ： 社会统一信用代码。
		/// </summary>
		[JsonProperty("identity_param")]
		public string IdentityParam { get; set; }

		/// <summary>
		///     产品码，直接使用［示例］给出的值
		/// </summary>
		[JsonProperty("product_code")]
		public string ProductCode { get; set; }

		/// <summary>
		///     商户请求的唯一标志，32位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性.建议:前面几位字符是商户自定义的简称,中间可以使用一段日期,结尾可以使用一个序列
		/// </summary>
		[JsonProperty("transaction_id")]
		public string TransactionId { get; set; }
	}
}