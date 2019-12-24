using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AestheticData Data Structure.
    /// </summary>
    [Serializable]
    public class AestheticData : AopObject
    {
        /// <summary>
        /// 返回执行信息，包括成功和错误
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 图片的美学评估得分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 标识返回结果，0表示成功 1表示异常
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用于标识当次请求
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
