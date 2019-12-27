using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffFeedbackstockorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffFeedbackstockorderSyncModel : AopObject
    {
        /// <summary>
        /// erp订单号
        /// </summary>
        [XmlElement("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 反馈类型  取消入库单：CANCEL_STOCK_IN_ORDER  取消出库单：CANCEL_STOCK_OUT_ORDER
        /// </summary>
        [XmlElement("feedback_type")]
        public string FeedbackType { get; set; }
    }
}
