using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityInfoAnalysisResponse.
	/// </summary>
	public class AlipaySecurityInfoAnalysisResponse : AopResponse
	{
		/// <summary>
		///     风险标签
		/// </summary>
		[JsonProperty("risk_code")]
		public string RiskCode { get; set; }

		/// <summary>
		///     风险等级
		/// </summary>
		[JsonProperty("risk_level")]
		public long RiskLevel { get; set; }
	}
}