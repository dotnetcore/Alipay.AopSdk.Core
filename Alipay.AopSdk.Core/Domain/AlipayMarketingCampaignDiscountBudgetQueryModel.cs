using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountBudgetQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignDiscountBudgetQueryModel : AopObject
	{
		/// <summary>
		///     预算名称
		/// </summary>
		[JsonProperty("budget_id")]
		public string BudgetId { get; set; }
	}
}