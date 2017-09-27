using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     PeriodInfo Data Structure.
	/// </summary>
	[Serializable]
	public class PeriodInfo : AopObject
	{
		/// <summary>
		///     单位
		/// </summary>
		[JsonProperty("dimension")]
		public string Dimension { get; set; }

		/// <summary>
		///     周期值
		/// </summary>
		[JsonProperty("value")]
		public long Value { get; set; }
	}
}