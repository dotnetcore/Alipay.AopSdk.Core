using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     Text Data Structure.
	/// </summary>
	[Serializable]
	public class Text : AopObject
	{
		/// <summary>
		///     文本消息的内容
		/// </summary>
		[JsonProperty("content")]
		public string Content { get; set; }

		/// <summary>
		///     文本消息的标题
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}