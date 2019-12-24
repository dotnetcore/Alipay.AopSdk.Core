using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationIssueConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneApplicationIssueConfirmModel : AopObject
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [XmlElement("application_no")]
        public string ApplicationNo { get; set; }

        /// <summary>
        /// payToIssue:支付后出单 issue:直接出单
        /// </summary>
        [XmlElement("issue_type")]
        public string IssueType { get; set; }
    }
}
