using System.Collections.Generic;
using System.Xml.Serialization;
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
		[XmlArray("report_condition_list")]
		[XmlArrayItem("custom_report_condition")]
		public List<CustomReportCondition> ReportConditionList { get; set; }
	}
}