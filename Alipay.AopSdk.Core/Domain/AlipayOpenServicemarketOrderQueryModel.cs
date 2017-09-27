using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenServicemarketOrderQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenServicemarketOrderQueryModel : AopObject
	{
		/// <summary>
		///     商户订单ID号
		/// </summary>
		[JsonProperty("commodity_order_id")]
		public string CommodityOrderId { get; set; }

		/// <summary>
		///     从第几页开始查询
		/// </summary>
		[JsonProperty("start_page")]
		public string StartPage { get; set; }
	}
}