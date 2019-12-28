using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOfflineMarketingVoucherCreateResponse.
	/// </summary>
	public class AlipayOfflineMarketingVoucherCreateResponse : AopResponse
	{
		/// <summary>
		///     活动id，过渡方案的兼容字段
		/// </summary>
		[JsonProperty("activity_id")]
		public string ActivityId { get; set; }

		/// <summary>
		///     券模板id
		/// </summary>
		[JsonProperty("voucher_id")]
		public string VoucherId { get; set; }
	}
}