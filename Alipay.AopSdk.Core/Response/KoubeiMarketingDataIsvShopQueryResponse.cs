using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataIsvShopQueryResponse.
	/// </summary>
	public class KoubeiMarketingDataIsvShopQueryResponse : AopResponse
	{
		/// <summary>
		///     门店摘要信息列表
		/// </summary>
		[JsonProperty("shop_summary_infos")]
		
		public List<ShopSummaryInfo> ShopSummaryInfos { get; set; }
	}
}