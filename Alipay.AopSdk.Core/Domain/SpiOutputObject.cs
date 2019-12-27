using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SpiOutputObject Data Structure.
    /// </summary>
    [Serializable]
    public class SpiOutputObject : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }
    }
}
