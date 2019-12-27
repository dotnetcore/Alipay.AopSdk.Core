using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Gavinmed Data Structure.
    /// </summary>
    [Serializable]
    public class Gavinmed : AopObject
    {
        /// <summary>
        /// 复杂类型嵌入
        /// </summary>
        [XmlArray("meds")]
        [XmlArrayItem("gavintest_new_levea_one")]
        public List<GavintestNewLeveaOne> Meds { get; set; }

        /// <summary>
        /// 退换货
        /// </summary>
        [XmlElement("str")]
        public string Str { get; set; }
    }
}
