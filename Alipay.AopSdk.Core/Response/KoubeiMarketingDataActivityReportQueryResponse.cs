using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataActivityReportQueryResponse.
	/// </summary>
	public class KoubeiMarketingDataActivityReportQueryResponse : AopResponse
	{
		/// <summary>
		///     报表
		/// </summary>
		[JsonProperty("report_data")]
		public string ReportData { get; set; }
	}
}