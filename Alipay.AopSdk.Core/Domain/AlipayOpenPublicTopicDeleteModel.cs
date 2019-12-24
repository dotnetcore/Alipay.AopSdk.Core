using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenPublicTopicDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicTopicDeleteModel : AopObject
    {
        /// <summary>
        /// 营销位id
        /// </summary>
        [XmlElement("topic_id")]
        public string TopicId { get; set; }
    }
}
