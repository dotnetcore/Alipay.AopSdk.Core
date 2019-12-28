using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayAccountExrateTraderequestCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayAccountExrateTraderequestCreateModel : AopObject
	{
		/// <summary>
		///     交易请求对象内容
		/// </summary>
		[JsonProperty("trade_request")]
		public TradeRequestVO TradeRequest { get; set; }
	}
}