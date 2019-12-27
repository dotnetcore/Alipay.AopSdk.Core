using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UserMailInfoOrder Data Structure.
    /// </summary>
    [Serializable]
    public class UserMailInfoOrder : AopObject
    {
        /// <summary>
        /// 联系所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 联系人国家
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 联系人所在县/区
        /// </summary>
        [XmlElement("county_district")]
        public string CountyDistrict { get; set; }

        /// <summary>
        /// 联系所在详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 商户ipRole(pid)
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 联系人名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系人省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 联系人所在街道
        /// </summary>
        [XmlElement("street")]
        public string Street { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
