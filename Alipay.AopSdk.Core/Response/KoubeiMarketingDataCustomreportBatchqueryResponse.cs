using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataCustomreportBatchqueryResponse.
	/// </summary>
	public class KoubeiMarketingDataCustomreportBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     分页输出自定义开放数据规则列表
		/// </summary>
		[JsonProperty("report_condition_list")]
		
		public List<CustomReportCondition> ReportConditionList { get; set; }
	}
}