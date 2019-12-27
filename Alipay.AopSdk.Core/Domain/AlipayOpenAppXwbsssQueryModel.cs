using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbsssQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppXwbsssQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("c")]
        [XmlArrayItem("number")]
        public List<long> C { get; set; }

        /// <summary>
        /// 描述描述描述描述
        /// </summary>
        [XmlElement("effect_date")]
        public string EffectDate { get; set; }
    }
}
