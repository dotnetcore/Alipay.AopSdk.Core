using System.Collections.Generic;
using System.Xml.Serialization;

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
		[XmlElement("current_pageno")]
		public string CurrentPageno { get; set; }

		/// <summary>
		///     门店列表ID，逗号分隔
		/// </summary>
		[XmlArray("shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopIds { get; set; }

		/// <summary>
		///     总页码数目
		/// </summary>
		[XmlElement("total_pageno")]
		public string TotalPageno { get; set; }
	}
}