using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CrowdRuleInfo Data Structure.
	/// </summary>
	[Serializable]
	public class CrowdRuleInfo : AopObject
	{
		/// <summary>
		///     规则描述
		/// </summary>
		[JsonProperty("ruledesc")]
		public string Ruledesc { get; set; }

		/// <summary>
		///     规则id
		/// </summary>
		[JsonProperty("ruleid")]
		public string Ruleid { get; set; }

		/// <summary>
		///     圈人规则的状态
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}