using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoDingMessageNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoDingMessageNotifyModel : AopObject
    {
        /// <summary>
        /// 钉钉通知@人列表
        /// </summary>
        [XmlElement("at_mobiles")]
        public string AtMobiles { get; set; }

        /// <summary>
        /// 钉钉通知内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 钉钉群token
        /// </summary>
        [XmlElement("ding_token")]
        public string DingToken { get; set; }
    }
}
