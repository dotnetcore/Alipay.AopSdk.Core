using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCashvoucherTemplateCreateResponse.
	/// </summary>
	public class AlipayMarketingCashvoucherTemplateCreateResponse : AopResponse
	{
		/// <summary>
		///     模板支付确认链接
		/// </summary>
		[JsonProperty("confirm_uri")]
		public string ConfirmUri { get; set; }

		/// <summary>
		///     资金订单号，模板支付时需要
		/// </summary>
		[JsonProperty("fund_order_no")]
		public string FundOrderNo { get; set; }

		/// <summary>
		///     券模板ID
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }
	}
}