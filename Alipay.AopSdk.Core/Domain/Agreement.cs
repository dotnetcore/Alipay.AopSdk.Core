using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Agreement Data Structure.
    /// </summary>
    [Serializable]
    public class Agreement : AopObject
    {
        /// <summary>
        /// 协议地址
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 协议名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
