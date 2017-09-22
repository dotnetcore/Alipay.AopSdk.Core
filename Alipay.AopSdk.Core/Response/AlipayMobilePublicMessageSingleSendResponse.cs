using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicMessageSingleSendResponse.
	/// </summary>
	public class AlipayMobilePublicMessageSingleSendResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[XmlElement("code")]
		public string Code { get; set; }

		/// <summary>
		///     结果描述
		/// </summary>
		[XmlElement("msg")]
		public string Msg { get; set; }
	}
}