using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RegionState Data Structure.
    /// </summary>
    [Serializable]
    public class RegionState : AopObject
    {
        /// <summary>
        /// 区域所在层
        /// </summary>
        [XmlElement("floor")]
        public long Floor { get; set; }

        /// <summary>
        /// 左端最大可放坐标(单位:毫米)
        /// </summary>
        [XmlElement("left_max")]
        public long LeftMax { get; set; }

        /// <summary>
        /// 左端最小可放坐标(单位:毫米)
        /// </summary>
        [XmlElement("left_min")]
        public long LeftMin { get; set; }

        /// <summary>
        /// 黄色区域插入选取商品后最左端坐标(单位:毫米)
        /// </summary>
        [XmlElement("left_push")]
        public long LeftPush { get; set; }
    }
}
