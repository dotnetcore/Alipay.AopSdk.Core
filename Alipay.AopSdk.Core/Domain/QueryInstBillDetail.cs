using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     QueryInstBillDetail Data Structure.
	/// </summary>
	[Serializable]
	public class QueryInstBillDetail : AopObject
	{
		/// <summary>
		///     明细key
		/// </summary>
		[JsonProperty("key")]
		public string Key { get; set; }

		/// <summary>
		///     明细描述
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     明细对应值
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}