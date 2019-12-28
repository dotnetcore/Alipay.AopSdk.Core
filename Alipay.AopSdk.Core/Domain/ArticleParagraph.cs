using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ArticleParagraph Data Structure.
	/// </summary>
	[Serializable]
	public class ArticleParagraph : AopObject
	{
		/// <summary>
		///     图片列表
		/// </summary>
		[JsonProperty("pictures")]
		
		public List<ArticlePicture> Pictures { get; set; }

		/// <summary>
		///     文章正文描述
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }
	}
}