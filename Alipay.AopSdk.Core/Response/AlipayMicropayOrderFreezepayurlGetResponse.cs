using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMicropayOrderFreezepayurlGetResponse.
	/// </summary>
	public class AlipayMicropayOrderFreezepayurlGetResponse : AopResponse
	{
		/// <summary>
		///     支付冻结金的地址
		/// </summary>
		[JsonProperty("pay_freeze_url")]
		public string PayFreezeUrl { get; set; }
	}
}