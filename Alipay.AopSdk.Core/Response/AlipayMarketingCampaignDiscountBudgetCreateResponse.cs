using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetCreateResponse : AopResponse
    {
        /// <summary>
        /// 预算ID
        /// </summary>
        [XmlElement("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 立减支付确认链接
        /// </summary>
        [XmlElement("confirm_uri")]
        public string ConfirmUri { get; set; }

        /// <summary>
        /// 资金订单号
        /// </summary>
        [XmlElement("fund_order_no")]
        public string FundOrderNo { get; set; }
    }
}
