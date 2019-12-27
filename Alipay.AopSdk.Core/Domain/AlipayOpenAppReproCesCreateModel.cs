using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppReproCesCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppReproCesCreateModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlArray("comp")]
        [XmlArrayItem("gavintest_new_levea_one")]
        public List<GavintestNewLeveaOne> Comp { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("nam")]
        public Gavinmed Nam { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [XmlArray("str")]
        [XmlArrayItem("string")]
        public List<string> Str { get; set; }
    }
}
