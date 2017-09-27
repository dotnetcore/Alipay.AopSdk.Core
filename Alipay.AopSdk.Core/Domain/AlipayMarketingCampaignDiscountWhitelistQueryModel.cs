using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountWhitelistQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignDiscountWhitelistQueryModel : AopObject
	{
		/// <summary>
		///     活动od
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }
	}
}