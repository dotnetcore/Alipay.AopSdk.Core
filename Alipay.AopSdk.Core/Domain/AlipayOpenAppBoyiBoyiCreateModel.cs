using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppBoyiBoyiCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppBoyiBoyiCreateModel : AopObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("com")]
        public GavintestNewLeveaOne Com { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("des")]
        public string Des { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("desd")]
        public GavinTestnew Desd { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("header")]
        public string Header { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("med")]
        public string Med { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
