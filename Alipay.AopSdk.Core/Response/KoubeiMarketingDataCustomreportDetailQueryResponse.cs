using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataCustomreportDetailQueryResponse.
	/// </summary>
	public class KoubeiMarketingDataCustomreportDetailQueryResponse : AopResponse
	{
		/// <summary>
		///     自定义报表规则条件的详细信息
		/// </summary>
		[JsonProperty("report_condition_info")]
		public CustomReportCondition ReportConditionInfo { get; set; }
	}
}