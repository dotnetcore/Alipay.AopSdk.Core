using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiSalesLeadsShopleadsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesLeadsShopleadsCreateModel : AopObject
    {
        /// <summary>
        /// 街道详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 分店名
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 品牌id，请联系业务获取
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 叶子类目id，请联系业务获取
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 市级码
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 营业执照上的公司、法人名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contacts_name")]
        public string ContactsName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("contacts_no")]
        public string ContactsNo { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [XmlElement("country_id")]
        public string CountryId { get; set; }

        /// <summary>
        /// 区级码
        /// </summary>
        [XmlElement("district_id")]
        public string DistrictId { get; set; }

        /// <summary>
        /// 扩展信息，JsonMap格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 主店名
        /// </summary>
        [XmlElement("head_shop_name")]
        public string HeadShopName { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 省、直辖市码
        /// </summary>
        [XmlElement("province_id")]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 工商注册时间
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 调用方请求id，业务请求相同时应保持一致，用于幂等
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
