using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Pair Data Structure.
    /// </summary>
    [Serializable]
    public class Pair : AopObject
    {
        /// <summary>
        /// KEY
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
