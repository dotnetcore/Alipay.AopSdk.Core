using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataMallDiscountQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataMallDiscountQueryModel : AopObject
	{
		/// <summary>
		///     商圈id
		/// </summary>
		[JsonProperty("mall_id")]
		public string MallId { get; set; }
	}
}