using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataCustomreportQueryResponse.
	/// </summary>
	public class KoubeiMarketingDataCustomreportQueryResponse : AopResponse
	{
		/// <summary>
		///     数据量
		/// </summary>
		[JsonProperty("count")]
		public string Count { get; set; }

		/// <summary>
		///     满足自定义报表规则的报表数据
		/// </summary>
		[JsonProperty("report_data")]
		
		public List<ReportDataItem> ReportData { get; set; }
	}
}