using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingExchangevoucherUseModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingExchangevoucherUseModel : AopObject
	{
		/// <summary>
		///     外部业务号，用户幂等控制。相同voucher_id和out_biz_no被认为是同一次核销
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }

		/// <summary>
		///     支付宝用户ID ，必须保证待使用的券ID归属于该支付宝用户ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }

		/// <summary>
		///     待使用的券id ，来自发券接口alipay.marketing.voucher.send
		/// </summary>
		[JsonProperty("voucher_id")]
		public string VoucherId { get; set; }
	}
}