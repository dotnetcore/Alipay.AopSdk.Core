using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertAdvChannelResponse Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertAdvChannelResponse : AopObject
	{
		/// <summary>
		///     广告内容模型
		/// </summary>
		[JsonProperty("adv_content_list")]
		
		public List<KbAdvertAdvContentResponse> AdvContentList { get; set; }

		/// <summary>
		///     广告id
		/// </summary>
		[JsonProperty("adv_id")]
		public string AdvId { get; set; }

		/// <summary>
		///     渠道ID
		/// </summary>
		[JsonProperty("channel_id")]
		public string ChannelId { get; set; }

		/// <summary>
		///     渠道名称
		/// </summary>
		[JsonProperty("channel_name")]
		public string ChannelName { get; set; }

		/// <summary>
		///     渠道类型
		/// </summary>
		[JsonProperty("channel_type")]
		public string ChannelType { get; set; }
	}
}