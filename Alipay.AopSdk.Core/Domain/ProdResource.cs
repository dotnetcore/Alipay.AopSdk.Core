using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ProdResource Data Structure.
    /// </summary>
    [Serializable]
    public class ProdResource : AopObject
    {
        /// <summary>
        /// 资源项唯一标识
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 资源项名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 资源项类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 资源向内容
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
