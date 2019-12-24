using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingTessssssssssstQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingTessssssssssstQueryModel : AopObject
    {
        /// <summary>
        /// tset
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("object")]
        public SpiInputObject Object { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("params")]
        public AccessParams Params { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("x_name")]
        public string XName { get; set; }
    }
}
