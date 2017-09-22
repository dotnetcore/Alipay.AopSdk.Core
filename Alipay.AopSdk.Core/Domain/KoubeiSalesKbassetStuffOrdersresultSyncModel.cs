using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiSalesKbassetStuffOrdersresultSyncModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiSalesKbassetStuffOrdersresultSyncModel : AopObject
	{
		/// <summary>
		///     物料单据反馈列表，最大200条
		/// </summary>
		[XmlArray("orders_feedback")]
		[XmlArrayItem("access_orders_feed_back")]
		public List<AccessOrdersFeedBack> OrdersFeedback { get; set; }
	}
}