using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayCommerceTransportOfflinepayTradeSettleModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayCommerceTransportOfflinepayTradeSettleModel : AopObject
	{
		/// <summary>
		///     脱机交易列表
		/// </summary>
		[JsonProperty("trade_list")]
		
		public List<AlipayOfflineTrade> TradeList { get; set; }
	}
}