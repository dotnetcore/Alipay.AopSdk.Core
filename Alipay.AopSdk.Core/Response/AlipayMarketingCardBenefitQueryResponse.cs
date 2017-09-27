using System.Collections.Generic;
using Newtonsoft.Json;
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
		[JsonProperty("mcard_template_benefit_query")]
		
		public List<McardTemplateBenefitQuery> McardTemplateBenefitQuery { get; set; }
	}
}