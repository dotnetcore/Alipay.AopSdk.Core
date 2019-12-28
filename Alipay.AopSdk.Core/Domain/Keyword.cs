using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     Keyword Data Structure.
	/// </summary>
	[Serializable]
	public class Keyword : AopObject
	{
		/// <summary>
		///     当前文字颜色
		/// </summary>
		[JsonProperty("color")]
		public string Color { get; set; }

		/// <summary>
		///     模板中占位符的值
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}