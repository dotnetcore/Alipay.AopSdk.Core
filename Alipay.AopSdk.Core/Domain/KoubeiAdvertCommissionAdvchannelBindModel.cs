using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiAdvertCommissionAdvchannelBindModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiAdvertCommissionAdvchannelBindModel : AopObject
	{
		/// <summary>
		///     广告id
		/// </summary>
		[JsonProperty("adv_id")]
		public string AdvId { get; set; }

		/// <summary>
		///     渠道ID列表
		/// </summary>
		[JsonProperty("channel_id_list")]
		
		public List<string> ChannelIdList { get; set; }
	}
}