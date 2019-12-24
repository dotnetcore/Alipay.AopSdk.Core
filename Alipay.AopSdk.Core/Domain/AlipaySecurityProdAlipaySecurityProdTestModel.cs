using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdTestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAlipaySecurityProdTestModel : AopObject
    {
        /// <summary>
        /// ddd
        /// </summary>
        [XmlArray("cds")]
        [XmlArrayItem("string")]
        public List<string> Cds { get; set; }

        /// <summary>
        /// aaa
        /// </summary>
        [XmlElement("ddd")]
        public string Ddd { get; set; }
    }
}
