using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayTradeFastpayRefundQueryResponse.
	/// </summary>
	public class AlipayTradeFastpayRefundQueryResponse : AopResponse
	{
		/// <summary>
		///     本笔退款对应的退款请求号
		/// </summary>
		[JsonProperty("out_request_no")]
		public string OutRequestNo { get; set; }

		/// <summary>
		///     创建交易传入的商户订单号
		/// </summary>
		[JsonProperty("out_trade_no")]
		public string OutTradeNo { get; set; }

		/// <summary>
		///     本次退款请求，对应的退款金额
		/// </summary>
		[JsonProperty("refund_amount")]
		public string RefundAmount { get; set; }

		/// <summary>
		///     发起退款时，传入的退款原因
		/// </summary>
		[JsonProperty("refund_reason")]
		public string RefundReason { get; set; }

		/// <summary>
		///     该笔退款所对应的交易的订单金额
		/// </summary>
		[JsonProperty("total_amount")]
		public string TotalAmount { get; set; }

		/// <summary>
		///     支付宝交易号
		/// </summary>
		[JsonProperty("trade_no")]
		public string TradeNo { get; set; }
	}
}