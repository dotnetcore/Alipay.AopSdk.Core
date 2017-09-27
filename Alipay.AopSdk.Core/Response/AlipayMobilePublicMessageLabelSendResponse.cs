using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicMessageLabelSendResponse.
	/// </summary>
	public class AlipayMobilePublicMessageLabelSendResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     结果信息
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }

		/// <summary>
		///     消息ID
		/// </summary>
		[JsonProperty("msg_id")]
		public string MsgId { get; set; }
	}
}