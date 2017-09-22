using System;
using System.Xml.Serialization;

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
		[XmlElement("message_id")]
		public string MessageId { get; set; }
	}
}