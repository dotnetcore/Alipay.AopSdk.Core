using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlisisReportColumn Data Structure.
	/// </summary>
	[Serializable]
	public class AlisisReportColumn : AopObject
	{
		/// <summary>
		///     列别名
		/// </summary>
		[JsonProperty("alias")]
		public string Alias { get; set; }

		/// <summary>
		///     列值
		/// </summary>
		[JsonProperty("data")]
		public string Data { get; set; }
	}
}