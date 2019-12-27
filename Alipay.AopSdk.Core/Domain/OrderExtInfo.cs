using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OrderExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderExtInfo : AopObject
    {
        /// <summary>
        /// 键值
        /// </summary>
        [XmlElement("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [XmlElement("ext_value")]
        public string ExtValue { get; set; }
    }
}
