using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TrusteeshipAccountBillQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class TrusteeshipAccountBillQueryResponse : AopObject
    {
        /// <summary>
        /// 账单日
        /// </summary>
        [XmlElement("account_date")]
        public string AccountDate { get; set; }

        /// <summary>
        /// 流水类型，取值为I/O，I表示IN，即流入；O表示OUT，即流出。
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 涉及金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 账户剩余金额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 托管流水号
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trans_dt")]
        public string TransDt { get; set; }

        /// <summary>
        /// 支付宝ID
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
