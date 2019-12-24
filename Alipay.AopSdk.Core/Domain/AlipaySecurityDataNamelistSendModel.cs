using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityDataNamelistSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataNamelistSendModel : AopObject
    {
        /// <summary>
        /// 业务名称,用来区分消息处理类目
        /// </summary>
        [XmlElement("bizname")]
        public string Bizname { get; set; }

        /// <summary>
        /// json格式具体内容.
        /// </summary>
        [XmlElement("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 对方系统名称,用于追踪消息发送来源系统
        /// </summary>
        [XmlElement("sysname")]
        public string Sysname { get; set; }
    }
}
