using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankPaymentTradeOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeOrderCreateModel : AopObject
    {
        /// <summary>
        /// 币种值
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 业务事件码
        /// </summary>
        [XmlElement("ev_code")]
        public string EvCode { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("goods_info")]
        [XmlArrayItem("bk_pos_goods_info")]
        public List<BkPosGoodsInfo> GoodsInfo { get; set; }

        /// <summary>
        /// 外部商户业务订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 网商合作伙伴ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 支付类型。pay:支付；refund:退款
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 对账关联ID，用以对账时关联网商与对账方订单的唯一ID。(支付单号、支付流水等能够串联两边订单的唯一ID均可作为对账关联ID)
        /// </summary>
        [XmlElement("recon_related_no")]
        public string ReconRelatedNo { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 卖家终端ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 订单总金额，单位为分，取值范围[1,100000000]
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
