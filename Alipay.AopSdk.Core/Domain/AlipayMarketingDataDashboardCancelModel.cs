using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingDataDashboardCancelModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingDataDashboardCancelModel : AopObject
	{
		/// <summary>
		///     批量取消仪表盘授权
		/// </summary>
		[JsonProperty("dashboard_ids")]
		
		public List<string> DashboardIds { get; set; }
	}
}