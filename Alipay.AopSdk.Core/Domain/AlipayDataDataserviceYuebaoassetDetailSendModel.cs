using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayDataDataserviceYuebaoassetDetailSendModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayDataDataserviceYuebaoassetDetailSendModel : AopObject
	{
		/// <summary>
		///     资产负债报表数据列表
		/// </summary>
		[JsonProperty("alm_report_data")]
		
		public List<AlmReportData> AlmReportData { get; set; }
	}
}