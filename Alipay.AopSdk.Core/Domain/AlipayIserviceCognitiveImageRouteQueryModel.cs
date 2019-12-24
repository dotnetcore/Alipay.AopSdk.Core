using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveImageRouteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveImageRouteQueryModel : AopObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务请求详细内容
        /// </summary>
        [XmlArray("ctx")]
        [XmlArrayItem("string")]
        public List<string> Ctx { get; set; }

        /// <summary>
        /// 业务pv唯一id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
