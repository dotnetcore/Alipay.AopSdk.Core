using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingCampaignActivityBatchqueryResponse.
	/// </summary>
	public class KoubeiMarketingCampaignActivityBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     活动列表
		/// </summary>
		[JsonProperty("camp_sets")]
		
		public List<CampBaseDto> CampSets { get; set; }

		/// <summary>
		///     总数量
		/// </summary>
		[JsonProperty("total_number")]
		public string TotalNumber { get; set; }
	}
}