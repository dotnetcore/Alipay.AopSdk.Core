using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodShopCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodShopCreateModel : AopObject
    {
        /// <summary>
        /// 西湖区文三路国际大厦
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 创建人PID
        /// </summary>
        [XmlElement("creator_pid")]
        public string CreatorPid { get; set; }

        /// <summary>
        /// 区县
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// {"key":"value"}
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 行业类目
        /// </summary>
        [XmlElement("industry_category")]
        public string IndustryCategory { get; set; }

        /// <summary>
        /// 门店商户PID
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 虚拟门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店属性
        /// </summary>
        [XmlElement("shop_property")]
        public string ShopProperty { get; set; }

        /// <summary>
        /// 门店类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }
    }
}
