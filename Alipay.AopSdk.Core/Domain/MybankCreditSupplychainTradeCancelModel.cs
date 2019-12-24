using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradeCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainTradeCancelModel : AopObject
    {
        /// <summary>
        /// 买家会员信息
        /// </summary>
        [XmlElement("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 渠道，枚举如下：TMGXBL：天猫供销保理，TYZBL：通用自保理，TMZBL：天猫自保理，DSCYFRZ：大搜车预付融资，TMJX：天猫经销池融资
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 扩展字段，json类型的字符串
        /// </summary>
        [XmlElement("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 幂等编号，用于幂等控制，格式：机构ipRoleId_yyyymmddhhmmss_8位uniqId
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 卖家会员信息
        /// </summary>
        [XmlElement("seller")]
        public Member Seller { get; set; }

        /// <summary>
        /// FACTORING：保理，PREPAYMENT：预付融资，CREDITPAY：信任付，POOL：池融资
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
