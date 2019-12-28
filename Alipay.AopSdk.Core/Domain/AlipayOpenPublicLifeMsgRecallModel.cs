using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicLifeMsgRecallModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicLifeMsgRecallModel : AopObject
	{
		/// <summary>
		///     消息id
		/// </summary>
		[JsonProperty("message_id")]
		public string MessageId { get; set; }
	}
}