using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingCampaignQrcodeQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingCampaignQrcodeQueryModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }
	}
}