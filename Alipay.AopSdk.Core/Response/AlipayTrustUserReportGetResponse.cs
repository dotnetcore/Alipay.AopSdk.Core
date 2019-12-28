using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayTrustUserReportGetResponse.
	/// </summary>
	public class AlipayTrustUserReportGetResponse : AopResponse
	{
		/// <summary>
		///     报告内容，格式详见示例代码
		/// </summary>
		[JsonProperty("report")]
		public string Report { get; set; }
	}
}