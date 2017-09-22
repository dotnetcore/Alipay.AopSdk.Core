using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbadvertVoucherManual Data Structure.
	/// </summary>
	[Serializable]
	public class KbadvertVoucherManual : AopObject
	{
		/// <summary>
		///     说明
		/// </summary>
		[XmlArray("details")]
		[XmlArrayItem("string")]
		public List<string> Details { get; set; }

		/// <summary>
		///     标题
		/// </summary>
		[XmlElement("title")]
		public string Title { get; set; }
	}
}