using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingCampaignCrowdCreateResponse.
	/// </summary>
	public class KoubeiMarketingCampaignCrowdCreateResponse : AopResponse
	{
		/// <summary>
		///     返回的人群组的唯一标识
		/// </summary>
		[JsonProperty("crowd_group_id")]
		public string CrowdGroupId { get; set; }
	}
}