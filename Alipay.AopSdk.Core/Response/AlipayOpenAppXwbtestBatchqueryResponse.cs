using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenAppXwbtestBatchqueryResponse.
	/// </summary>
	public class AlipayOpenAppXwbtestBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     1
		/// </summary>
		[XmlElement("xwb")]
		public string Xwb { get; set; }
	}
}