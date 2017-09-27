using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     TableListResult Data Structure.
	/// </summary>
	[Serializable]
	public class TableListResult : AopObject
	{
		/// <summary>
		///     桌名
		/// </summary>
		[JsonProperty("table_name")]
		public string TableName { get; set; }

		/// <summary>
		///     桌号
		/// </summary>
		[JsonProperty("table_num")]
		public string TableNum { get; set; }
	}
}