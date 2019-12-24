using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ReceiptQuoteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptQuoteInfo : AopObject
    {
        /// <summary>
        /// The base currency
        /// </summary>
        [XmlElement("base_currency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// a currency pair is the quotation of the relative value of a currency unit against the unit of another currency.
        /// </summary>
        [XmlElement("base_currency_unit")]
        public string BaseCurrencyUnit { get; set; }

        /// <summary>
        /// the time of this quote to be unavaible
        /// </summary>
        [XmlElement("expiry_time")]
        public string ExpiryTime { get; set; }

        /// <summary>
        /// fxRate
        /// </summary>
        [XmlElement("fx_rate")]
        public string FxRate { get; set; }

        /// <summary>
        /// quoteId
        /// </summary>
        [XmlElement("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// sourceCurrency
        /// </summary>
        [XmlElement("source_currency")]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// the startTime this quote to be available.
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// targetCurrency
        /// </summary>
        [XmlElement("target_currency")]
        public string TargetCurrency { get; set; }
    }
}
