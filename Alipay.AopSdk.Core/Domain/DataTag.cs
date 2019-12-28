using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     DataTag Data Structure.
	/// </summary>
	[Serializable]
	public class DataTag : AopObject
	{
		/// <summary>
		///     聚合方式NONE,COUNT,COUNT_DISTINCT,DISTINCT,MIN,MAX,SUM
		/// </summary>
		[JsonProperty("aggregate")]
		public string Aggregate { get; set; }

		/// <summary>
		///     列别名
		/// </summary>
		[JsonProperty("alias")]
		public string Alias { get; set; }

		/// <summary>
		///     标签CODE
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }
	}
}