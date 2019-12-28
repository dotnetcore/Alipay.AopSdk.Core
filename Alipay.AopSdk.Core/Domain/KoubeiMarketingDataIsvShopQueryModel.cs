using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataIsvShopQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataIsvShopQueryModel : AopObject
	{
		/// <summary>
		///     门店ID列表（单次最多查询100个门店）
		/// </summary>
		[JsonProperty("shop_ids")]
		
		public List<string> ShopIds { get; set; }
	}
}