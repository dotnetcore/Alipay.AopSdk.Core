using System.Collections.Generic;
using Newtonsoft.Json;
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
		[JsonProperty("report_data")]
		
		public List<AlisisReportRow> ReportData { get; set; }
	}
}