using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCardBenefitQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCardBenefitQueryModel : AopObject
	{
		/// <summary>
		///     权益ID
		/// </summary>
		[JsonProperty("benefit_id")]
		public string BenefitId { get; set; }

		/// <summary>
		///     会员卡模板ID
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }
	}
}