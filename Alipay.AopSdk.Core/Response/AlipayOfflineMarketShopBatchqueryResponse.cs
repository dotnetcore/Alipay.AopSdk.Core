using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOfflineMarketShopBatchqueryResponse.
	/// </summary>
	public class AlipayOfflineMarketShopBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     当前页码
		/// </summary>
		[JsonProperty("current_pageno")]
		public string CurrentPageno { get; set; }

		/// <summary>
		///     门店列表ID，逗号分隔
		/// </summary>
		[JsonProperty("shop_ids")]
		
		public List<string> ShopIds { get; set; }

		/// <summary>
		///     总页码数目
		/// </summary>
		[JsonProperty("total_pageno")]
		public string TotalPageno { get; set; }
	}
}