using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenDesCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenDesCreateModel : AopObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [XmlArray("des")]
        [XmlArrayItem("gavintest_new_levea_one")]
        public List<GavintestNewLeveaOne> Des { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [XmlArray("test")]
        [XmlArrayItem("boolean")]
        public List<bool> Test { get; set; }
    }
}
