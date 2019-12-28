using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingVoucherAuthSendResponse.
	/// </summary>
	public class AlipayMarketingVoucherAuthSendResponse : AopResponse
	{
		/// <summary>
		///     券ID
		/// </summary>
		[JsonProperty("voucher_id")]
		public string VoucherId { get; set; }
	}
}