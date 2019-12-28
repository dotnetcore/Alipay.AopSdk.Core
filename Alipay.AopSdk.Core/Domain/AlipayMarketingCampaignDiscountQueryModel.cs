using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignDiscountQueryModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }
	}
}