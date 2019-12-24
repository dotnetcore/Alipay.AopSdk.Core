using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedExtensionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedExtensionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 扩展区套数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 扩展区信息
        /// </summary>
        [XmlArray("extensions")]
        [XmlArrayItem("query_extension")]
        public List<QueryExtension> Extensions { get; set; }
    }
}
