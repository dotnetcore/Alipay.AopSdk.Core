using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayTradeOrderSettleResponse.
	/// </summary>
	public class AlipayTradeOrderSettleResponse : AopResponse
	{
		/// <summary>
		///     支付宝交易号
		/// </summary>
		[JsonProperty("trade_no")]
		public string TradeNo { get; set; }
	}
}