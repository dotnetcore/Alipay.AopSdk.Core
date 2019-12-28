using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InsMktFactorDTO Data Structure.
	/// </summary>
	[Serializable]
	public class InsMktFactorDTO : AopObject
	{
		/// <summary>
		///     规则因子
		/// </summary>
		[JsonProperty("key")]
		public string Key { get; set; }

		/// <summary>
		///     规则因子值
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}