using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneTokenCreateModel : AopObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 1:身份证  2:军官证  3:士兵证  8:台湾居民通行证  A:护照  B:户口簿  Z:其它证件
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 采集人员的支付宝会员标识
        /// </summary>
        [XmlElement("operator_user_id")]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// 家长手机号码
        /// </summary>
        [XmlElement("parent_phone")]
        public string ParentPhone { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [XmlElement("student_name")]
        public string StudentName { get; set; }

        /// <summary>
        /// 教育场景子业务
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }
    }
}
