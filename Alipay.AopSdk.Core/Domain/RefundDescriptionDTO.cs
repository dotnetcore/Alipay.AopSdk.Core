using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RefundDescriptionDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RefundDescriptionDTO : AopObject
    {
        /// <summary>
        /// 本次支付用户实付的金额 = 应付金额 - 支付优惠中商家优惠金额 - 支付优惠中平台补贴金额
        /// </summary>
        [XmlElement("buyer_amount")]
        public string BuyerAmount { get; set; }

        /// <summary>
        /// 失败原因编码
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 口碑订单级优惠(特价菜、阶梯减)
        /// </summary>
        [XmlElement("kb_order_discount")]
        public string KbOrderDiscount { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("online_payment_no")]
        public string OnlinePaymentNo { get; set; }

        /// <summary>
        /// 本次应付金额=实际支付金额+支付级优惠金额
        /// </summary>
        [XmlElement("payable_amount")]
        public string PayableAmount { get; set; }

        /// <summary>
        /// 支付单id
        /// </summary>
        [XmlElement("payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// 本次支付的支付方式，包括但不限于：(1) ALIPAY：支付宝(2) WECHAT：微信
        /// </summary>
        [XmlElement("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 退款状态，(1) SUCCESS表示退款成功 (2) PROCESSING表示退款中
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 本次支付商户实收的金额 = 用户实付金额 + 平台补贴金额 = 本次订单应付金额 - 本次支付商家优惠金额
        /// </summary>
        [XmlElement("seller_amount")]
        public string SellerAmount { get; set; }
    }
}
