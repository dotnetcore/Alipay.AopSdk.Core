using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenServicemarketOrderAcceptModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenServicemarketOrderAcceptModel : AopObject
	{
		/// <summary>
		///     服务商品订单ID
		/// </summary>
		[JsonProperty("commodity_order_id")]
		public string CommodityOrderId { get; set; }
	}
}