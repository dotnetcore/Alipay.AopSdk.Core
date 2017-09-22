using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCardBenefitCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCardBenefitCreateModel : AopObject
	{
		/// <summary>
		///     会员卡模板外部权益
		/// </summary>
		[XmlElement("mcard_template_benefit")]
		public McardTemplateBenefit McardTemplateBenefit { get; set; }
	}
}