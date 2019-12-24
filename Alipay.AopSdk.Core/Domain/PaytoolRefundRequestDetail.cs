using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PaytoolRefundRequestDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PaytoolRefundRequestDetail : AopObject
    {
        /// <summary>
        /// 支付宝支付工具单据号，和商户支付工具单据号不能同时为空。
        /// </summary>
        [XmlElement("paytool_bill_no")]
        public string PaytoolBillNo { get; set; }

        /// <summary>
        /// 商户外部支付工具单据号。和支付宝支付工具单据号不能同时为空。
        /// </summary>
        [XmlElement("paytool_request_no")]
        public string PaytoolRequestNo { get; set; }

        /// <summary>
        /// 退款支付工具金额。单位为元，精确到小数点后两位，取值范围[0.01,100000000]。注：退款金额不可大于支付金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
