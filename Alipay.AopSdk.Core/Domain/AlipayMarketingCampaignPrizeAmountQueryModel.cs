using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignPrizeAmountQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignPrizeAmountQueryModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }

		/// <summary>
		///     奖品id
		/// </summary>
		[JsonProperty("prize_id")]
		public string PrizeId { get; set; }
	}
}