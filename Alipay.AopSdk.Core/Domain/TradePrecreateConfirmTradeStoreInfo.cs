using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TradePrecreateConfirmTradeStoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradePrecreateConfirmTradeStoreInfo : AopObject
    {
        /// <summary>
        /// 店铺所在城市id
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 店铺所在城市简体中文名
        /// </summary>
        [XmlElement("city_name_sc")]
        public string CityNameSc { get; set; }

        /// <summary>
        /// 店铺ID(外标)
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 店铺MCC
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
