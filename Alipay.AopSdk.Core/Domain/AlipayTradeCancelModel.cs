using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayTradeCancelModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayTradeCancelModel : AopObject
	{
		/// <summary>
		///     原支付请求的商户订单号,和支付宝交易号不能同时为空
		/// </summary>
		[JsonProperty("out_trade_no")]
		public string OutTradeNo { get; set; }

		/// <summary>
		///     支付宝交易号，和商户订单号不能同时为空
		/// </summary>
		[JsonProperty("trade_no")]
		public string TradeNo { get; set; }
	}
}