using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TradeItemResult Data Structure.
    /// </summary>
    [Serializable]
    public class TradeItemResult : AopObject
    {
        /// <summary>
        /// 支付宝订单号。对账使用，不脱敏
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 交易退款时间
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 商品备注信息
        /// </summary>
        [XmlElement("goods_memo")]
        public string GoodsMemo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_title")]
        public string GoodsTitle { get; set; }

        /// <summary>
        /// 商户订单号，创建支付宝交易时传入的信息。对账使用，不脱敏
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [XmlElement("net_mdiscount")]
        public string NetMdiscount { get; set; }

        /// <summary>
        /// 对方账户
        /// </summary>
        [XmlElement("other_account")]
        public string OtherAccount { get; set; }

        /// <summary>
        /// 订单退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 服务费金额
        /// </summary>
        [XmlElement("service_fee")]
        public string ServiceFee { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [XmlElement("store_no")]
        public string StoreNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 订单状态(待付款,成功,关闭,待发货,待确认收货,已预付,进行中)
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 业务类型，帮助商户作为对账参考
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
