using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberTemplateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 会员模板id
        /// </summary>
        [XmlArray("member_template_ids")]
        [XmlArrayItem("string")]
        public List<string> MemberTemplateIds { get; set; }
    }
}
