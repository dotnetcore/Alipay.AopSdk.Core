using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCampaignActivityOfflineCreateResponse.
	/// </summary>
	public class AlipayMarketingCampaignActivityOfflineCreateResponse : AopResponse
	{
		/// <summary>
		///     创建成功的活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }

		/// <summary>
		///     创建成功的券模版id
		/// </summary>
		[JsonProperty("prize_id")]
		public string PrizeId { get; set; }
	}
}