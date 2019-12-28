using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingMallShoppromoinfoQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingMallShoppromoinfoQueryModel : AopObject
	{
		/// <summary>
		///     商圈id
		/// </summary>
		[JsonProperty("mall_id")]
		public string MallId { get; set; }

		/// <summary>
		///     商圈下店铺id列表
		/// </summary>
		[JsonProperty("shop_ids")]
		
		public List<string> ShopIds { get; set; }
	}
}