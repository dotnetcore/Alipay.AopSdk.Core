using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlArray("activities")]
        [XmlArrayItem("merchant_online_activity_open_model")]
        public List<MerchantOnlineActivityOpenModel> Activities { get; set; }
    }
}
