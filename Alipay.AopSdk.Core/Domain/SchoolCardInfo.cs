using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SchoolCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SchoolCardInfo : AopObject
    {
        /// <summary>
        /// 支付宝校园卡卡号
        /// </summary>
        [XmlElement("alipay_card_no")]
        public string AlipayCardNo { get; set; }

        /// <summary>
        /// 认证类型， 1:官方校园卡；2:一卡通
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [XmlElement("campus_no")]
        public string CampusNo { get; set; }

        /// <summary>
        /// 支付宝校园卡类型，1:学生卡；2.教工卡
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 创建时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 展示码类型， 0:在线码；1:离线码
        /// </summary>
        [XmlElement("display_code_type")]
        public string DisplayCodeType { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 一卡通实体卡号
        /// </summary>
        [XmlElement("physical_card_number")]
        public string PhysicalCardNumber { get; set; }

        /// <summary>
        /// 支付宝学校编码
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校标识码
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// isv分配的学生短码
        /// </summary>
        [XmlElement("short_code")]
        public string ShortCode { get; set; }

        /// <summary>
        /// 支付宝校园卡状态，0:无效，1:有效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
