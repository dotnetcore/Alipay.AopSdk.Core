using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AssuranceInfo Data Structure.
	/// </summary>
	[Serializable]
	public class AssuranceInfo : AopObject
	{
		/// <summary>
		///     服务保障的描述
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		///     服务保障的标题
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}