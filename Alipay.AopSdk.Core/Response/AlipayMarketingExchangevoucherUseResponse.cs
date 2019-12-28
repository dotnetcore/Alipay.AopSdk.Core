using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingExchangevoucherUseResponse.
	/// </summary>
	public class AlipayMarketingExchangevoucherUseResponse : AopResponse
	{
		/// <summary>
		///     被核销的券ID
		/// </summary>
		[JsonProperty("voucher_id")]
		public string VoucherId { get; set; }
	}
}