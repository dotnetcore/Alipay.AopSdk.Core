using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayTransferThirdpartyBillCreateResponse.
	/// </summary>
	public class AlipayTransferThirdpartyBillCreateResponse : AopResponse
	{
		/// <summary>
		///     支付宝转账交易号
		/// </summary>
		[JsonProperty("order_id")]
		public string OrderId { get; set; }

		/// <summary>
		///     交易类型，固定为transfer
		/// </summary>
		[JsonProperty("order_type")]
		public string OrderType { get; set; }

		/// <summary>
		///     外部应用创建的交易ID
		/// </summary>
		[JsonProperty("payment_id")]
		public string PaymentId { get; set; }
	}
}