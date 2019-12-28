using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingVoucherSendResponse.
	/// </summary>
	public class AlipayMarketingVoucherSendResponse : AopResponse
	{
		/// <summary>
		///     支付宝用户ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }

		/// <summary>
		///     券ID
		/// </summary>
		[JsonProperty("voucher_id")]
		public string VoucherId { get; set; }
	}
}