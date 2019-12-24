using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// GoodsState Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsState : AopObject
    {
        /// <summary>
        /// 算法商品Id
        /// </summary>
        [XmlElement("algorithm_goods_id")]
        public string AlgorithmGoodsId { get; set; }

        /// <summary>
        /// 商品所在层数
        /// </summary>
        [XmlElement("floor")]
        public long Floor { get; set; }

        /// <summary>
        /// 已有商品左端坐标(单位:毫米)
        /// </summary>
        [XmlElement("left_loc")]
        public long LeftLoc { get; set; }
    }
}
