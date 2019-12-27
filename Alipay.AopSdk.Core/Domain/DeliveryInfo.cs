using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DeliveryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryInfo : AopObject
    {
        /// <summary>
        /// 市区编码，国标码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [XmlElement("consignee")]
        public string Consignee { get; set; }

        /// <summary>
        /// 收件人联系方式
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 详细地区
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 县区编码，国标码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 省份编码，国标码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [XmlElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
