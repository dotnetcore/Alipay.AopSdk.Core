using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicMessageTotalSendResponse.
	/// </summary>
	public class AlipayOpenPublicMessageTotalSendResponse : AopResponse
	{
		/// <summary>
		///     消息ID
		/// </summary>
		[JsonProperty("message_id")]
		public string MessageId { get; set; }
	}
}