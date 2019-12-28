using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ReportErrorFeature Data Structure.
	/// </summary>
	[Serializable]
	public class ReportErrorFeature : AopObject
	{
		/// <summary>
		///     桌号
		/// </summary>
		[JsonProperty("table_num")]
		public string TableNum { get; set; }
	}
}