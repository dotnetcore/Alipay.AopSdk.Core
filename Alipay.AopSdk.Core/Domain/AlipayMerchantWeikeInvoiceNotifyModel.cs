using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMerchantWeikeInvoiceNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantWeikeInvoiceNotifyModel : AopObject
    {
        /// <summary>
        /// 申请ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 开票拒绝反馈错误码
        /// </summary>
        [XmlElement("feedback_code")]
        public string FeedbackCode { get; set; }

        /// <summary>
        /// 开票拒绝反馈原因
        /// </summary>
        [XmlElement("feedback_msg")]
        public string FeedbackMsg { get; set; }

        /// <summary>
        /// 反馈状态:true开票成功；false开票拒绝
        /// </summary>
        [XmlElement("feedback_result")]
        public bool FeedbackResult { get; set; }

        /// <summary>
        /// 发票种类，0=电子发票，1=纸质发票，2=专票
        /// </summary>
        [XmlElement("invoice_kind")]
        public long InvoiceKind { get; set; }

        /// <summary>
        /// isv的物流信息
        /// </summary>
        [XmlArray("logistics_info")]
        [XmlArrayItem("isv_logistics_info")]
        public List<IsvLogisticsInfo> LogisticsInfo { get; set; }
    }
}
