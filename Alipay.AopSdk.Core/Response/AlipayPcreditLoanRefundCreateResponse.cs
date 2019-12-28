using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayPcreditLoanRefundCreateResponse.
	/// </summary>
	public class AlipayPcreditLoanRefundCreateResponse : AopResponse
	{
		/// <summary>
		///     受理的还款申请单号
		/// </summary>
		[JsonProperty("loan_repay_no")]
		public string LoanRepayNo { get; set; }
	}
}