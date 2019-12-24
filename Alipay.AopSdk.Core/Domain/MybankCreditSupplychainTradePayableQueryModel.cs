using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradePayableQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainTradePayableQueryModel : AopObject
    {
        /// <summary>
        /// 买家会员信息
        /// </summary>
        [XmlElement("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// FACTORING：保理，PREPAYMENT：预付融资，CREDITPAY：信任付，PREPAYBILL：预付电票
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
