using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertAdvContent Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertAdvContent : AopObject
	{
		/// <summary>
		///     二维码
		/// </summary>
		[JsonProperty("codec")]
		public string Codec { get; set; }

		/// <summary>
		///     访问地址
		/// </summary>
		[JsonProperty("link_url")]
		public string LinkUrl { get; set; }
	}
}