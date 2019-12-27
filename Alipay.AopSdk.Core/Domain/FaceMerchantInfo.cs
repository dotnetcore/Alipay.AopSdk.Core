using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// FaceMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceMerchantInfo : AopObject
    {
        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 品牌编码
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 机具Mac地址
        /// </summary>
        [XmlElement("device_mac")]
        public string DeviceMac { get; set; }

        /// <summary>
        /// 机具编码
        /// </summary>
        [XmlElement("device_num")]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 经纬度
        /// </summary>
        [XmlElement("geo")]
        public string Geo { get; set; }

        /// <summary>
        /// 机具分组编码
        /// </summary>
        [XmlElement("group")]
        public string Group { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// ISV ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// WI-FI Mac地址
        /// </summary>
        [XmlElement("wifimac")]
        public string Wifimac { get; set; }

        /// <summary>
        /// WI-FI 名称
        /// </summary>
        [XmlElement("wifiname")]
        public string Wifiname { get; set; }
    }
}
