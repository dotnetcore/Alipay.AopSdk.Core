using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// GavintestNewonline Data Structure.
    /// </summary>
    [Serializable]
    public class GavintestNewonline : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("dem")]
        [XmlArrayItem("string")]
        public List<string> Dem { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("string")]
        public GavintestNewLeveaOne String { get; set; }
    }
}
