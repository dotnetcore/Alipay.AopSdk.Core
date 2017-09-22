using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
		[XmlArray("dashboard_ids")]
		[XmlArrayItem("string")]
		public List<string> DashboardIds { get; set; }
	}
}