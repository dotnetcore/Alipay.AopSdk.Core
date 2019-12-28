using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiSalesKbassetStuffPurchaseorderQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiSalesKbassetStuffPurchaseorderQueryModel : AopObject
	{
		/// <summary>
		///     每页大小：最小1，最大100
		/// </summary>
		[JsonProperty("page_size")]
		public string PageSize { get; set; }
	}
}