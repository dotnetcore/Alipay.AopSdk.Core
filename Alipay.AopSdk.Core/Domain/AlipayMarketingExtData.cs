using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingExtData Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingExtData : AopObject
	{
		/// <summary>
		///     复杂模型
		/// </summary>
		[JsonProperty("lbs_info")]
		public AlipayMarketingIbsInfo LbsInfo { get; set; }

		/// <summary>
		///     外部uid
		/// </summary>
		[JsonProperty("out_user_id")]
		public string OutUserId { get; set; }
	}
}