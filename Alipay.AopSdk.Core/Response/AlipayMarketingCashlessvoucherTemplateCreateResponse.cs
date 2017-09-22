using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCashlessvoucherTemplateCreateResponse.
	/// </summary>
	public class AlipayMarketingCashlessvoucherTemplateCreateResponse : AopResponse
	{
		/// <summary>
		///     模板ID
		/// </summary>
		[XmlElement("template_id")]
		public string TemplateId { get; set; }
	}
}