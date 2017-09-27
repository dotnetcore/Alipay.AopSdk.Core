using System;
using System.Collections.Generic;
using Newtonsoft.Json;

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
		[JsonProperty("orders_feedback")]
		
		public List<AccessOrdersFeedBack> OrdersFeedback { get; set; }
	}
}