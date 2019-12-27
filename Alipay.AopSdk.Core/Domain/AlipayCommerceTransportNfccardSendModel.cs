using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceTransportNfccardSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportNfccardSendModel : AopObject
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡片状态（FREEZE：冻结，CANCEL：销卡）
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 发卡机构代码
        /// </summary>
        [XmlElement("issue_org_no")]
        public string IssueOrgNo { get; set; }
    }
}
