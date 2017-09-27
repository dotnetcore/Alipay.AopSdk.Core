using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountBudgetCreateResponse.
	/// </summary>
	public class AlipayMarketingCampaignDiscountBudgetCreateResponse : AopResponse
	{
		/// <summary>
		///     预算ID
		/// </summary>
		[JsonProperty("budget_id")]
		public string BudgetId { get; set; }
	}
}