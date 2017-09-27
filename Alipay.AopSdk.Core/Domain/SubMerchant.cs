using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SubMerchant Data Structure.
	/// </summary>
	[Serializable]
	public class SubMerchant : AopObject
	{
		/// <summary>
		///     二级商户的支付宝id
		/// </summary>
		[JsonProperty("merchant_id")]
		public string MerchantId { get; set; }
	}
}