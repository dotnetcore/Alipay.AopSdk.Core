using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingDataDashboardApplyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingDataDashboardApplyModel : AopObject
	{
		/// <summary>
		///     仪表盘ID列表
		/// </summary>
		[JsonProperty("dashboard_ids")]
		
		public List<string> DashboardIds { get; set; }
	}
}