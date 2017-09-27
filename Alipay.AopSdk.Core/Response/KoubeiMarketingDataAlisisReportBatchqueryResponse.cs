using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataAlisisReportBatchqueryResponse.
	/// </summary>
	public class KoubeiMarketingDataAlisisReportBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     报表列表信息
		/// </summary>
		[JsonProperty("report_list")]
		
		public List<AlisisReport> ReportList { get; set; }

		/// <summary>
		///     总记录数
		/// </summary>
		[JsonProperty("total_count")]
		public string TotalCount { get; set; }
	}
}