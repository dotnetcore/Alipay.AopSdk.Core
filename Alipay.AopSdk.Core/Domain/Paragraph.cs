using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
		[XmlArray("pictures")]
		[XmlArrayItem("picture")]
		public List<Picture> Pictures { get; set; }

		/// <summary>
		///     正文介绍
		/// </summary>
		[XmlElement("text")]
		public string Text { get; set; }
	}
}