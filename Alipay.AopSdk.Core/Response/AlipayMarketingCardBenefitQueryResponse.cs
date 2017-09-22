using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCardBenefitQueryResponse.
	/// </summary>
	public class AlipayMarketingCardBenefitQueryResponse : AopResponse
	{
		/// <summary>
		///     会员卡模板外部权益列表
		/// </summary>
		[XmlArray("mcard_template_benefit_query")]
		[XmlArrayItem("mcard_template_benefit_query")]
		public List<McardTemplateBenefitQuery> McardTemplateBenefitQuery { get; set; }
	}
}