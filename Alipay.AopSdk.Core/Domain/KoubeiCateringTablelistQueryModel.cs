using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiCateringTablelistQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiCateringTablelistQueryModel : AopObject
	{
		/// <summary>
		///     门店id
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }
	}
}