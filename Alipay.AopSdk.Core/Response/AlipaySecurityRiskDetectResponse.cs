using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityRiskDetectResponse.
	/// </summary>
	public class AlipaySecurityRiskDetectResponse : AopResponse
	{
		/// <summary>
		///     结果码
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