using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCampaignActivityOfflineTriggerResponse.
	/// </summary>
	public class AlipayMarketingCampaignActivityOfflineTriggerResponse : AopResponse
	{
		/// <summary>
		///     外部奖品ID
		/// </summary>
		[JsonProperty("out_prize_id")]
		public string OutPrizeId { get; set; }
	}
}