using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MultiCurrencyMoneyOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class MultiCurrencyMoneyOpenApi : AopObject
    {
        /// <summary>
        /// 分
        /// </summary>
        [XmlElement("cent")]
        public long Cent { get; set; }

        /// <summary>
        /// 币种类型值
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }
    }
}
