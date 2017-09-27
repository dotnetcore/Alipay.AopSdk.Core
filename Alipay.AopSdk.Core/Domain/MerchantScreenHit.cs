using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     MerchantScreenHit Data Structure.
	/// </summary>
	[Serializable]
	public class MerchantScreenHit : AopObject
	{
		/// <summary>
		///     送检的实体类型，如CEO，控股人，等
		/// </summary>
		[JsonProperty("input_type")]
		public string InputType { get; set; }

		/// <summary>
		///     命中详情
		/// </summary>
		[JsonProperty("risk_detail")]
		public string RiskDetail { get; set; }
	}
}