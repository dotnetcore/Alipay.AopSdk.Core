using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MapParameter Data Structure.
    /// </summary>
    [Serializable]
    public class MapParameter : AopObject
    {
        /// <summary>
        /// 参数的名字
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
