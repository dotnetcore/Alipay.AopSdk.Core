using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     Paragraph Data Structure.
	/// </summary>
	[Serializable]
	public class Paragraph : AopObject
	{
		/// <summary>
		///     图片列表
		/// </summary>
		[JsonProperty("pictures")]
		
		public List<Picture> Pictures { get; set; }

		/// <summary>
		///     正文介绍
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }
	}
}