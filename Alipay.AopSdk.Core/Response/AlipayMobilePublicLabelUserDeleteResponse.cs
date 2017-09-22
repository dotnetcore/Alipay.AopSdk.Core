using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicLabelUserDeleteResponse.
	/// </summary>
	public class AlipayMobilePublicLabelUserDeleteResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[XmlElement("code")]
		public string Code { get; set; }

		/// <summary>
		///     结果信息
		/// </summary>
		[XmlElement("msg")]
		public string Msg { get; set; }
	}
}