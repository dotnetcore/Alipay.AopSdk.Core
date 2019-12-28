using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignDrawcampQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignDrawcampQueryModel : AopObject
	{
		/// <summary>
		///     抽奖活动id，通过alipay.marketing.campaign.drawcamp.create接口返回
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }
	}
}