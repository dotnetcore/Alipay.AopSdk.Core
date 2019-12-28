using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOfflineMarketProductBatchqueryResponse.
	/// </summary>
	public class AlipayOfflineMarketProductBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     当前页码
		/// </summary>
		[JsonProperty("current_pageno")]
		public long CurrentPageno { get; set; }

		/// <summary>
		///     商品列表ID，逗号分隔
		/// </summary>
		[JsonProperty("item_ids")]
		
		public List<string> ItemIds { get; set; }

		/// <summary>
		///     总页码数
		/// </summary>
		[JsonProperty("total_pageno")]
		public long TotalPageno { get; set; }
	}
}