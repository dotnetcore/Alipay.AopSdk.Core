using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InsLiability Data Structure.
	/// </summary>
	[Serializable]
	public class InsLiability : AopObject
	{
		/// <summary>
		///     责任描述
		/// </summary>
		[JsonProperty("liability_desc")]
		public string LiabilityDesc { get; set; }

		/// <summary>
		///     责任名称
		/// </summary>
		[JsonProperty("liability_name")]
		public string LiabilityName { get; set; }

		/// <summary>
		///     保额
		/// </summary>
		[JsonProperty("sum_insured")]
		public InsSumInsured SumInsured { get; set; }
	}
}