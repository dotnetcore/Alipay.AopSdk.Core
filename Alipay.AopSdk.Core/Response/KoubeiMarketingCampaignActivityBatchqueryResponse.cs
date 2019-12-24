using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlArray("camp_sets")]
        [XmlArrayItem("camp_base_dto")]
        public List<CampBaseDto> CampSets { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_number")]
        public string TotalNumber { get; set; }
    }
}
