using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobileBeaconMessageSendResponse.
	/// </summary>
	public class AlipayMobileBeaconMessageSendResponse : AopResponse
	{
		/// <summary>
		///     操作返回码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     操作提示文案
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}