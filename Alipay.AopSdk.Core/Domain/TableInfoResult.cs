using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     TableInfoResult Data Structure.
	/// </summary>
	[Serializable]
	public class TableInfoResult : AopObject
	{
		/// <summary>
		///     返回TableListResult集合
		/// </summary>
		[JsonProperty("table_info_list")]
		
		public List<TableListResult> TableInfoList { get; set; }
	}
}