using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RubbishDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RubbishDTO : AopObject
    {
        /// <summary>
        /// 垃圾类别
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 垃圾名称
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }
    }
}
