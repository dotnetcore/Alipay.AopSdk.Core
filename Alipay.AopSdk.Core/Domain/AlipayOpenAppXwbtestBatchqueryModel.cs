using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenAppXwbtestBatchqueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenAppXwbtestBatchqueryModel : AopObject
	{
		/// <summary>
		///     1
		/// </summary>
		[XmlElement("xwb")]
		public string Xwb { get; set; }
	}
}