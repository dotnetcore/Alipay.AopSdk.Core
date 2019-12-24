using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMemberBenefitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AntMemberBenefitInfo : AopObject
    {
        /// <summary>
        /// 权益对应跳转地址
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 权益图标地址
        /// </summary>
        [XmlElement("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 权益状态：RECEIVABLE（可领取），RECEIVED（已领取），OTHER（其它）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 会员权益标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 会员权益价值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
