using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingAdvertisingQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingAdvertisingQueryModel : AopObject
	{
		/// <summary>
		///     广告Id，唯一标识一条广告
		/// </summary>
		[JsonProperty("ad_id")]
		public string AdId { get; set; }
	}
}