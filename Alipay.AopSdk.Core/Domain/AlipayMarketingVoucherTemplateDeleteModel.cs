using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingVoucherTemplateDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingVoucherTemplateDeleteModel : AopObject
	{
		/// <summary>
		///     券模板ID
		/// </summary>
		[XmlElement("template_id")]
		public string TemplateId { get; set; }
	}
}