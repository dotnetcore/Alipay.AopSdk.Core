using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayTrustUserAuthSendResponse.
	/// </summary>
	public class AlipayTrustUserAuthSendResponse : AopResponse
	{
		/// <summary>
		///     当授权通知发送成功时，为T；否则用业务错误码表示
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}