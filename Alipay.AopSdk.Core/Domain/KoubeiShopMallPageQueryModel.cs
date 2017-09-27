using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiShopMallPageQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiShopMallPageQueryModel : AopObject
	{
		/// <summary>
		///     商圈id
		/// </summary>
		[JsonProperty("mall_id")]
		public string MallId { get; set; }
	}
}