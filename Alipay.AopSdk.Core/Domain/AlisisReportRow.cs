using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlisisReportRow Data Structure.
	/// </summary>
	[Serializable]
	public class AlisisReportRow : AopObject
	{
		/// <summary>
		///     报表行信息，每个对象是一列的数据
		/// </summary>
		[JsonProperty("row_data")]
		
		public List<AlisisReportColumn> RowData { get; set; }
	}
}