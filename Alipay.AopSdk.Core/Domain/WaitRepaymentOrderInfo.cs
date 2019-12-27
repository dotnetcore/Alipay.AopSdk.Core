using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// WaitRepaymentOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WaitRepaymentOrderInfo : AopObject
    {
        /// <summary>
        /// 垫资单id
        /// </summary>
        [XmlElement("advance_order_id")]
        public string AdvanceOrderId { get; set; }

        /// <summary>
        /// 买家的支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 通常为商户签约的收单产品码
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 原始的业务单号，通常为支付宝交易号
        /// </summary>
        [XmlElement("orig_biz_order_id")]
        public string OrigBizOrderId { get; set; }

        /// <summary>
        /// 垫资金额
        /// </summary>
        [XmlElement("wait_repayment_amount")]
        public long WaitRepaymentAmount { get; set; }
    }
}
