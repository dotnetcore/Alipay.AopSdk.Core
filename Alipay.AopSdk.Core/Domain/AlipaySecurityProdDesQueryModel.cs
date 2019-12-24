using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityProdDesQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdDesQueryModel : AopObject
    {
        /// <summary>
        /// 121
        /// </summary>
        [XmlElement("com")]
        public GavinTestnew Com { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("test")]
        [XmlArrayItem("string")]
        public List<string> Test { get; set; }
    }
}
