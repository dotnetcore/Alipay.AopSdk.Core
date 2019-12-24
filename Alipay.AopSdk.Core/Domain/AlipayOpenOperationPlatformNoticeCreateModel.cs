using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenOperationPlatformNoticeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationPlatformNoticeCreateModel : AopObject
    {
        /// <summary>
        /// 站内信内容字段
        /// </summary>
        [XmlElement("notice_content")]
        public string NoticeContent { get; set; }

        /// <summary>
        /// 站内信title字段
        /// </summary>
        [XmlElement("notice_title")]
        public string NoticeTitle { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
