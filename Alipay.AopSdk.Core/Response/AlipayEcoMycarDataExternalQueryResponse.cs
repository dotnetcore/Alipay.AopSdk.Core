using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoMycarDataExternalQueryResponse.
	/// </summary>
	public class AlipayEcoMycarDataExternalQueryResponse : AopResponse
	{
		/// <summary>
		///     30
		/// </summary>
		[XmlElement("external_system_name")]
		public string ExternalSystemName { get; set; }

		/// <summary>
		///     outter_response
		/// </summary>
		[XmlElement("query_result")]
		public string QueryResult { get; set; }
	}
}