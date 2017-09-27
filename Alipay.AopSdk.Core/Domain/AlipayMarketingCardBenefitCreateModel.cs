using System;
using Newtonsoft.Json;

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
		[JsonProperty("mcard_template_benefit")]
		public McardTemplateBenefit McardTemplateBenefit { get; set; }
	}
}