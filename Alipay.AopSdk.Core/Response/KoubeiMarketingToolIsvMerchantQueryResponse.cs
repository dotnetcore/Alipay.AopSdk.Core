using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingToolIsvMerchantQueryResponse.
	/// </summary>
	public class KoubeiMarketingToolIsvMerchantQueryResponse : AopResponse
	{
		/// <summary>
		///     商户信息列表
		/// </summary>
		[JsonProperty("merchant_infos")]
		
		public List<IsvMerchantInfo> MerchantInfos { get; set; }

		/// <summary>
		///     门店总量
		/// </summary>
		[JsonProperty("shop_count")]
		public string ShopCount { get; set; }

		/// <summary>
		///     门店详情列表信息
		/// </summary>
		[JsonProperty("shop_summary_infos")]
		
		public List<ShopSummaryInfo> ShopSummaryInfos { get; set; }
	}
}