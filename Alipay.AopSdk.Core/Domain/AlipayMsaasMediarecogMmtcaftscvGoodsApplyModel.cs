using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvGoodsApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvGoodsApplyModel : AopObject
    {
        /// <summary>
        /// 商品上新批次号
        /// </summary>
        [XmlElement("batch_num")]
        public string BatchNum { get; set; }

        /// <summary>
        /// 上新商品信息列表
        /// </summary>
        [XmlArray("goods_infos")]
        [XmlArrayItem("apply_goods_info")]
        public List<ApplyGoodsInfo> GoodsInfos { get; set; }

        /// <summary>
        /// 视觉货柜机型ID
        /// </summary>
        [XmlElement("machine_type_id")]
        public string MachineTypeId { get; set; }
    }
}
