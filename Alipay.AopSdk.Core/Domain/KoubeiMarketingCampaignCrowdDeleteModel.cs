using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingCampaignCrowdDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingCampaignCrowdDeleteModel : AopObject
	{
		/// <summary>
		///     人群组的唯一标识ID
		/// </summary>
		[JsonProperty("crowd_group_id")]
		public string CrowdGroupId { get; set; }
	}
}