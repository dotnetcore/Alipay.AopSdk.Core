using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicThirdCustomerServiceResponse.
	/// </summary>
	public class AlipayOpenPublicThirdCustomerServiceResponse : AopResponse
	{
		/// <summary>
		///     授权给第三方渠道商的服务窗名称
		/// </summary>
		[XmlElement("public_name")]
		public string PublicName { get; set; }
	}
}