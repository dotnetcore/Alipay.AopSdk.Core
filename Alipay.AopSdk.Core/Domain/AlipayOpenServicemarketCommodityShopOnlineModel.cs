using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenServicemarketCommodityShopOnlineModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenServicemarketCommodityShopOnlineModel : AopObject
	{
		/// <summary>
		///     服务插件ID
		/// </summary>
		[JsonProperty("commodity_id")]
		public string CommodityId { get; set; }

		/// <summary>
		///     店铺ID
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }
	}
}