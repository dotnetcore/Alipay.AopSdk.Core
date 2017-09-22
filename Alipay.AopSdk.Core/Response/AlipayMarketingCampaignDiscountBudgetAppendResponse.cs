using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountBudgetAppendResponse.
	/// </summary>
	public class AlipayMarketingCampaignDiscountBudgetAppendResponse : AopResponse
	{
		/// <summary>
		///     预算ID
		/// </summary>
		[XmlElement("budget_id")]
		public string BudgetId { get; set; }
	}
}