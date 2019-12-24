using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveAswfDagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveAswfDagQueryModel : AopObject
    {
        /// <summary>
        /// 业务唯一标识，不可空
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务的任务描述
        /// </summary>
        [XmlElement("ctxs")]
        public string Ctxs { get; set; }

        /// <summary>
        /// DAG模板ID，不可空
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 业务请求唯一id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
