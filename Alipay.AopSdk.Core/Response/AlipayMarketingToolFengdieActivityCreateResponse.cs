using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingToolFengdieActivityCreateResponse.
	/// </summary>
	public class AlipayMarketingToolFengdieActivityCreateResponse : AopResponse
	{
		/// <summary>
		///     H5应用的唯一id
		/// </summary>
		[JsonProperty("activity_id")]
		public long ActivityId { get; set; }
	}
}