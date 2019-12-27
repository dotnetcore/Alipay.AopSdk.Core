using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// GoodsReturnOrder Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsReturnOrder : AopObject
    {
        /// <summary>
        /// 退货单号
        /// </summary>
        [XmlElement("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// 退货单类型
        /// </summary>
        [XmlElement("erp_order_type")]
        public string ErpOrderType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 退货明细
        /// </summary>
        [XmlArray("order_item")]
        [XmlArrayItem("goods_return_order_item")]
        public List<GoodsReturnOrderItem> OrderItem { get; set; }

        /// <summary>
        /// 退货单关联的原erpOrder单据
        /// </summary>
        [XmlElement("ori_erp_order")]
        public string OriErpOrder { get; set; }

        /// <summary>
        /// 退货单关联的原erpOrder类型
        /// </summary>
        [XmlElement("ori_erp_order_type")]
        public string OriErpOrderType { get; set; }
    }
}
