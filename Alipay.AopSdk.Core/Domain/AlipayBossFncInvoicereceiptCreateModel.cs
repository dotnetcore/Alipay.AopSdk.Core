using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayBossFncInvoicereceiptCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoicereceiptCreateModel : AopObject
    {
        /// <summary>
        /// 账单金额变更消息事件码  AR_MTHLY_BILL_CREATE:应收账单创建,  AR_MTHLY_BILL_CHANGE:应收金额更新
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 账单金额变更消息事件类型  CREATE:创建事件,UPDATE:更新事件
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 月帐单信息
        /// </summary>
        [XmlElement("monthly_bill")]
        public ArMonthlyBillDTO MonthlyBill { get; set; }

        /// <summary>
        /// 事件全局id，可以使用uuid
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 消息来源 01:主站，02：芝麻，03:金融云,04:微贷
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }
    }
}
