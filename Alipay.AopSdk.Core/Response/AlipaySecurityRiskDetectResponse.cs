using System.Xml.Serialization;

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
		[XmlElement("risk_code")]
		public string RiskCode { get; set; }

		/// <summary>
		///     风险等级
		/// </summary>
		[XmlElement("risk_level")]
		public long RiskLevel { get; set; }
	}
}