using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbadvertChannelTypeResponse Data Structure.
	/// </summary>
	[Serializable]
	public class KbadvertChannelTypeResponse : AopObject
	{
		/// <summary>
		///     渠道描述
		/// </summary>
		[JsonProperty("desc")]
		public string Desc { get; set; }

		/// <summary>
		///     排序，暂时无用
		/// </summary>
		[JsonProperty("order")]
		public string Order { get; set; }

		/// <summary>
		///     类型
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
	}
}