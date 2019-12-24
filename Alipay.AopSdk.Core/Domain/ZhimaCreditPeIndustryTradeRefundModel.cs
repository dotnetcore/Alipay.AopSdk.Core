using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaCreditPeIndustryTradeRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeIndustryTradeRefundModel : AopObject
    {
        /// <summary>
        /// 退款金额,单位元,支持两位小数
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展信息字段，格式:json，注意，如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 退款描述,该字段在支付宝账单直接展示给用户
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 扣款时传入的扣款资金单号
        /// </summary>
        [XmlElement("out_fund_no")]
        public string OutFundNo { get; set; }

        /// <summary>
        /// 退款资金单号，需要保证唯一, 退款失败继续使用该退款资金单号进行退款
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
