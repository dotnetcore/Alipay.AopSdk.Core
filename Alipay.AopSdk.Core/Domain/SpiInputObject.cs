using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SpiInputObject Data Structure.
    /// </summary>
    [Serializable]
    public class SpiInputObject : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }
    }
}
