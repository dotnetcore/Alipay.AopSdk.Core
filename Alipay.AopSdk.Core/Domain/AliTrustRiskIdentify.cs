using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AliTrustRiskIdentify Data Structure.
	/// </summary>
	[Serializable]
	public class AliTrustRiskIdentify : AopObject
	{
		/// <summary>
		///     芝麻信用风险名单详情列表
		/// </summary>
		[JsonProperty("details")]
		
		public List<ZhimaRiskDetail> Details { get; set; }

		/// <summary>
		///     当有风险时,为"T";无风险识别是为"F"
		/// </summary>
		[JsonProperty("is_risk")]
		public string IsRisk { get; set; }

		/// <summary>
		///     已废弃
		/// </summary>
		[JsonProperty("risk_tag")]
		public string RiskTag { get; set; }
	}
}