using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCardDeleteResponse.
	/// </summary>
	public class AlipayMarketingCardDeleteResponse : AopResponse
	{
		/// <summary>
		///     支付宝端删卡业务流水号
		/// </summary>
		[JsonProperty("biz_serial_no")]
		public string BizSerialNo { get; set; }
	}
}