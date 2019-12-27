using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketYcstestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketYcstestQueryModel : AopObject
    {
        /// <summary>
        /// aaaa
        /// </summary>
        [XmlElement("in_1")]
        public string In1 { get; set; }

        /// <summary>
        /// 222
        /// </summary>
        [XmlElement("in_2")]
        public bool In2 { get; set; }

        /// <summary>
        /// 333
        /// </summary>
        [XmlElement("in_3")]
        public string In3 { get; set; }

        /// <summary>
        /// 444
        /// </summary>
        [XmlElement("in_4")]
        public long In4 { get; set; }

        /// <summary>
        /// 55
        /// </summary>
        [XmlElement("in_5")]
        public string In5 { get; set; }

        /// <summary>
        /// 66666
        /// </summary>
        [XmlElement("in_6")]
        public XwbTestData In6 { get; set; }
    }
}
