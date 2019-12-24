using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipaySecurityRiskContentDetectResponse.
    /// </summary>
    public class AlipaySecurityRiskContentDetectResponse : AopResponse
    {
        /// <summary>
        /// 表示处理结果，REJECTED表示拦截，PASSED表示放过。
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 命中的关键词列表
        /// </summary>
        [XmlArray("keywords")]
        [XmlArrayItem("string")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 业务唯一识别码，可用来对应异步识别结果
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
