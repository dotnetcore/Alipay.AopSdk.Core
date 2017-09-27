using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignActivityOfflineTriggerModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignActivityOfflineTriggerModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }

		/// <summary>
		///     用户id
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}