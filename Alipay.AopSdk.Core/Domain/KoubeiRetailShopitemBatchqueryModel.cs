using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiRetailShopitemBatchqueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiRetailShopitemBatchqueryModel : AopObject
	{
		/// <summary>
		///     查询店铺商品查询入参
		/// </summary>
		[JsonProperty("shop_items")]
		
		public List<RequestExtShopItemQuery> ShopItems { get; set; }
	}
}