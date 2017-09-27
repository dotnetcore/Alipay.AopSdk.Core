using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataAlisisReportQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataAlisisReportQueryModel : AopObject
	{
		/// <summary>
		///     报表查询过滤条件
		/// </summary>
		[JsonProperty("conditions")]
		
		public List<ReportQueryCondition> Conditions { get; set; }

		/// <summary>
		///     报表唯一标识
		/// </summary>
		[JsonProperty("report_uk")]
		public string ReportUk { get; set; }
	}
}