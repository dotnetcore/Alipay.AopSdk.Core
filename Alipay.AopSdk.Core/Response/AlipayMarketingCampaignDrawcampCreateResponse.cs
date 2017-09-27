using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCampaignDrawcampCreateResponse.
	/// </summary>
	public class AlipayMarketingCampaignDrawcampCreateResponse : AopResponse
	{
		/// <summary>
		///     抽奖活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }
	}
}