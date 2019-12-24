using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ItemExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemExtInfo : AopObject
    {
        /// <summary>
        /// 扩展信息的key
        /// </summary>
        [XmlElement("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 扩展信息的值
        /// </summary>
        [XmlElement("ext_value")]
        public string ExtValue { get; set; }
    }
}
