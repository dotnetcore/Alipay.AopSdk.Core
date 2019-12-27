using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenAppMessageSubscriptionQueryResponse.
    /// </summary>
    public class AlipayOpenAppMessageSubscriptionQueryResponse : AopResponse
    {
        /// <summary>
        /// 消息接入方式，例如HTTP
        /// </summary>
        [XmlElement("comm_type")]
        public string CommType { get; set; }

        /// <summary>
        /// 消息标签
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 消息主题名称
        /// </summary>
        [XmlElement("topic")]
        public string Topic { get; set; }
    }
}
