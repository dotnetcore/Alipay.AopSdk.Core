using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiItemExtitemQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiItemExtitemQueryModel : AopObject
	{
		/// <summary>
		///     商品编码
		/// </summary>
		[JsonProperty("item_code")]
		public string ItemCode { get; set; }
	}
}