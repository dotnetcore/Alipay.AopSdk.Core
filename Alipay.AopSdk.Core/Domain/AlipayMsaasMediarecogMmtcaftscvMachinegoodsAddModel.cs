using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddModel : AopObject
    {
        /// <summary>
        /// 当前请求选取商品算法Id
        /// </summary>
        [XmlElement("algorithm_goods_id")]
        public string AlgorithmGoodsId { get; set; }

        /// <summary>
        /// 商品摆放姿态
        /// </summary>
        [XmlElement("display_mode")]
        public string DisplayMode { get; set; }

        /// <summary>
        /// 柜内已有商品摆放状态
        /// </summary>
        [XmlArray("exist_goods_state")]
        [XmlArrayItem("goods_state")]
        public List<GoodsState> ExistGoodsState { get; set; }

        /// <summary>
        /// 货柜层数
        /// </summary>
        [XmlElement("floor_num")]
        public long FloorNum { get; set; }

        /// <summary>
        /// 货柜型号
        /// </summary>
        [XmlElement("machine_type_id")]
        public string MachineTypeId { get; set; }
    }
}
