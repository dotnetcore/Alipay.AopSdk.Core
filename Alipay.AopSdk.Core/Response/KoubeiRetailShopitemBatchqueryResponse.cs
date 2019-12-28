using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiRetailShopitemBatchqueryResponse.
	/// </summary>
	public class KoubeiRetailShopitemBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     店铺商品集合
		/// </summary>
		[JsonProperty("shopitemlist")]
		
		public List<ExtShopItem> Shopitemlist { get; set; }
	}
}