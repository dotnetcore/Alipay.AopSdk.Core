using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignCashDetailQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignCashDetailQueryModel : AopObject
	{
		/// <summary>
		///     要查询的现金红包活动号
		/// </summary>
		[JsonProperty("crowd_no")]
		public string CrowdNo { get; set; }
	}
}