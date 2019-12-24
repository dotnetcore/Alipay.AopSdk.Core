using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UserMailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class UserMailInfoVO : AopObject
    {
        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 县区
        /// </summary>
        [XmlElement("county_district")]
        public string CountyDistrict { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 收件人信息ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// pid用于指定该地址归属的PID，应对集团模式的商户所设定,发票邮寄地址根据PID确定
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [XmlElement("street")]
        public string Street { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
