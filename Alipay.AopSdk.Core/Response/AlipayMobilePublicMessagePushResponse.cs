using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicMessagePushResponse.
	/// </summary>
	public class AlipayMobilePublicMessagePushResponse : AopResponse
	{
		/// <summary>
		///     成功
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     消息ID
		/// </summary>
		[JsonProperty("data")]
		public string Data { get; set; }

		/// <summary>
		///     成功
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}