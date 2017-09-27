using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenServicemarketOrderItemCompleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenServicemarketOrderItemCompleteModel : AopObject
	{
		/// <summary>
		///     订购服务插件订单号
		/// </summary>
		[JsonProperty("commodity_order_id")]
		public string CommodityOrderId { get; set; }

		/// <summary>
		///     订购插件选择的某一店铺ID
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }
	}
}