using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     LabelContext Data Structure.
	/// </summary>
	[Serializable]
	public class LabelContext : AopObject
	{
		/// <summary>
		///     标签组发圈人的单个过滤器信息
		/// </summary>
		[JsonProperty("a")]
		public LabelFilter A { get; set; }
	}
}