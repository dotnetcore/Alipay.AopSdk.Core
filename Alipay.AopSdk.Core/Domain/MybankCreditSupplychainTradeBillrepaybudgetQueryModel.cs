using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradeBillrepaybudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainTradeBillrepaybudgetQueryModel : AopObject
    {
        /// <summary>
        /// 买家信息
        /// </summary>
        [XmlElement("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品销售码
        /// </summary>
        [XmlElement("sale_pd_code")]
        public string SalePdCode { get; set; }
    }
}
