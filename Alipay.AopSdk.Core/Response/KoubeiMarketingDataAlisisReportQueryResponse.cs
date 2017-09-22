using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataAlisisReportQueryResponse.
	/// </summary>
	public class KoubeiMarketingDataAlisisReportQueryResponse : AopResponse
	{
		/// <summary>
		///     报表数据
		/// </summary>
		[XmlArray("report_data")]
		[XmlArrayItem("alisis_report_row")]
		public List<AlisisReportRow> ReportData { get; set; }
	}
}