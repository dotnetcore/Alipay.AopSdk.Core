using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IcrowdUseParam Data Structure.
    /// </summary>
    [Serializable]
    public class IcrowdUseParam : AopObject
    {
        /// <summary>
        /// 接口上下文
        /// </summary>
        [XmlElement("context")]
        public IcrowdUseContext Context { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [XmlArray("external_info")]
        [XmlArrayItem("string")]
        public List<string> ExternalInfo { get; set; }

        /// <summary>
        /// 要调用的方法ID
        /// </summary>
        [XmlElement("method_id")]
        public string MethodId { get; set; }
    }
}
