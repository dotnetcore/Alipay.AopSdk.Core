using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CreditPayMoneyVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayMoneyVO : AopObject
    {
        /// <summary>
        /// 金额，单位元
        /// </summary>
        [XmlElement("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 币种代码
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
