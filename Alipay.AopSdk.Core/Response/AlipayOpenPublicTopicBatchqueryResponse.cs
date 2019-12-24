using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenPublicTopicBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicTopicBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 营销位列表
        /// </summary>
        [XmlArray("topic_list")]
        [XmlArrayItem("topic")]
        public List<Topic> TopicList { get; set; }
    }
}
