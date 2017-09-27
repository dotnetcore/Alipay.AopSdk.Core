using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingCampaignRecruitApplyQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingCampaignRecruitApplyQueryModel : AopObject
	{
		/// <summary>
		///     运营活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }

		/// <summary>
		///     分页号
		/// </summary>
		[JsonProperty("page_num")]
		public string PageNum { get; set; }

		/// <summary>
		///     分页大小,最大值200
		/// </summary>
		[JsonProperty("page_size")]
		public string PageSize { get; set; }
	}
}