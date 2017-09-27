using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountWhitelistUpdateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignDiscountWhitelistUpdateModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }

		/// <summary>
		///     白名单。逗号分隔开
		/// </summary>
		[JsonProperty("user_white_list")]
		public string UserWhiteList { get; set; }
	}
}