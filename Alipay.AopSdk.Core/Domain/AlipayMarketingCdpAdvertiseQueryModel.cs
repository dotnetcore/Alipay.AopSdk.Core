using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCdpAdvertiseQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCdpAdvertiseQueryModel : AopObject
	{
		/// <summary>
		///     广告Id，唯一标识一条广告
		/// </summary>
		[JsonProperty("ad_id")]
		public string AdId { get; set; }
	}
}