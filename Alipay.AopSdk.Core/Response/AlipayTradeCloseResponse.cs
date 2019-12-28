using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayTradeCloseResponse.
	/// </summary>
	public class AlipayTradeCloseResponse : AopResponse
	{
		/// <summary>
		///     创建交易传入的商户订单号
		/// </summary>
		[JsonProperty("out_trade_no")]
		public string OutTradeNo { get; set; }

		/// <summary>
		///     支付宝交易号
		/// </summary>
		[JsonProperty("trade_no")]
		public string TradeNo { get; set; }
	}
}