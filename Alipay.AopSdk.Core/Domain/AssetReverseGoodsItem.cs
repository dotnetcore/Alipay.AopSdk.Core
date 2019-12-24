using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AssetReverseGoodsItem Data Structure.
    /// </summary>
    [Serializable]
    public class AssetReverseGoodsItem : AopObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 阶段
        /// </summary>
        [XmlElement("phase")]
        public string Phase { get; set; }

        /// <summary>
        /// 逆向申请单ID
        /// </summary>
        [XmlElement("reverse_apply_order_id")]
        public string ReverseApplyOrderId { get; set; }

        /// <summary>
        /// 逆向申请单明细ID
        /// </summary>
        [XmlElement("reverse_apply_order_item_id")]
        public string ReverseApplyOrderItemId { get; set; }

        /// <summary>
        /// 标识类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 申请输入信息
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
