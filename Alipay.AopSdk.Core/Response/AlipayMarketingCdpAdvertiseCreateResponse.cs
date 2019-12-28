using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCdpAdvertiseCreateResponse.
	/// </summary>
	public class AlipayMarketingCdpAdvertiseCreateResponse : AopResponse
	{
		/// <summary>
		///     创建广告唯一标识
		/// </summary>
		[JsonProperty("ad_id")]
		public string AdId { get; set; }
	}
}