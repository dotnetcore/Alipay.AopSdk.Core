using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiAdvertCommissionChannelCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiAdvertCommissionChannelCreateModel : AopObject
	{
		/// <summary>
		///     新增渠道列表
		/// </summary>
		[JsonProperty("channels")]
		
		public List<KbAdvertAddChannelRequest> Channels { get; set; }
	}
}