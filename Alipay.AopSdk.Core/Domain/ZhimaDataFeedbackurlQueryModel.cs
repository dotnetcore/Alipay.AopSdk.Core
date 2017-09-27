using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ZhimaDataFeedbackurlQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class ZhimaDataFeedbackurlQueryModel : AopObject
	{
		/// <summary>
		///     在支付宝商户版注册支付宝账号id
		/// </summary>
		[JsonProperty("merchant_id")]
		public string MerchantId { get; set; }
	}
}