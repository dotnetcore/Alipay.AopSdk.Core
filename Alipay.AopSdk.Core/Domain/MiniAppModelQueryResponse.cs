using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MiniAppModelQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppModelQueryResponse : AopObject
    {
        /// <summary>
        /// 模型查询类型
        /// </summary>
        [XmlElement("model_type")]
        public string ModelType { get; set; }

        /// <summary>
        /// 小程序核心模型的json化字符串
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("string")]
        public List<string> Records { get; set; }
    }
}
