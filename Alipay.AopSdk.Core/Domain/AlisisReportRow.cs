using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
		[XmlArray("row_data")]
		[XmlArrayItem("alisis_report_column")]
		public List<AlisisReportColumn> RowData { get; set; }
	}
}