using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
		[XmlArray("pictures")]
		[XmlArrayItem("article_picture")]
		public List<ArticlePicture> Pictures { get; set; }

		/// <summary>
		///     文章正文描述
		/// </summary>
		[XmlElement("text")]
		public string Text { get; set; }
	}
}