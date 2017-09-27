using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     MybankFinanceYulibaoPriceQueryResponse.
	/// </summary>
	public class MybankFinanceYulibaoPriceQueryResponse : AopResponse
	{
		/// <summary>
		///     余利宝行情信息列表
		/// </summary>
		[JsonProperty("ylb_price_detail_infos")]
		
		public List<YLBPriceDetailInfo> YlbPriceDetailInfos { get; set; }
	}
}