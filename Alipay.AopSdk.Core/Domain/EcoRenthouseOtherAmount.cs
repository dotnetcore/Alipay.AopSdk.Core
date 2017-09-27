using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     EcoRenthouseOtherAmount Data Structure.
	/// </summary>
	[Serializable]
	public class EcoRenthouseOtherAmount : AopObject
	{
		/// <summary>
		///     30
		/// </summary>
		[JsonProperty("amount")]
		public string Amount { get; set; }

		/// <summary>
		///     费用名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     费用单位
		/// </summary>
		[JsonProperty("unit")]
		public string Unit { get; set; }
	}
}