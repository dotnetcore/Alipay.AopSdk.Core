using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicLabelQueryResponse.
	/// </summary>
	public class AlipayMobilePublicLabelQueryResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[XmlElement("code")]
		public string Code { get; set; }

		/// <summary>
		///     所有标签
		/// </summary>
		[XmlArray("labels")]
		[XmlArrayItem("string")]
		public List<string> Labels { get; set; }

		/// <summary>
		///     结果信息
		/// </summary>
		[XmlElement("msg")]
		public string Msg { get; set; }
	}
}