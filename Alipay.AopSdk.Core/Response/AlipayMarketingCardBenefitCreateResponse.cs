using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCardBenefitCreateResponse.
	/// </summary>
	public class AlipayMarketingCardBenefitCreateResponse : AopResponse
	{
		/// <summary>
		///     权益ID
		/// </summary>
		[JsonProperty("benefit_id")]
		public string BenefitId { get; set; }
	}
}