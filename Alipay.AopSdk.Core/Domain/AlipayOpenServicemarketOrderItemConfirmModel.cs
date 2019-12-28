using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenServicemarketOrderItemConfirmModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenServicemarketOrderItemConfirmModel : AopObject
	{
		/// <summary>
		///     商品订单ID
		/// </summary>
		[JsonProperty("commodity_order_id")]
		public string CommodityOrderId { get; set; }

		/// <summary>
		///     商家订购服务选择的某一门店的ID
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }
	}
}