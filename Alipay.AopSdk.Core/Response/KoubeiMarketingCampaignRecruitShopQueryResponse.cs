using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingCampaignRecruitShopQueryResponse.
	/// </summary>
	public class KoubeiMarketingCampaignRecruitShopQueryResponse : AopResponse
	{
		/// <summary>
		///     招商活动id
		/// </summary>
		[XmlElement("plan_id")]
		public string PlanId { get; set; }

		/// <summary>
		///     总量
		/// </summary>
		[XmlElement("shop_count")]
		public string ShopCount { get; set; }

		/// <summary>
		///     招商门店确认详情
		/// </summary>
		[XmlArray("shop_info")]
		[XmlArrayItem("recruit_shop_info")]
		public List<RecruitShopInfo> ShopInfo { get; set; }
	}
}