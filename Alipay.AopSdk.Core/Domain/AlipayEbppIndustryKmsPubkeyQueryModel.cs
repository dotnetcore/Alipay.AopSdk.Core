using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppIndustryKmsPubkeyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryKmsPubkeyQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 证件号码的hash值，使用MD5算法获取的hash
        /// </summary>
        [XmlElement("cert_no_hash")]
        public string CertNoHash { get; set; }

        /// <summary>
        /// 证件类型  可选值（身份证：IDENTITY_CARD）
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
