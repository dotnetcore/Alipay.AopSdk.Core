using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveIdentityrelationAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntarchiveIdentityrelationAddModel : AopObject
    {
        /// <summary>
        /// 扩展信息,Map格式JSON序列化表示
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 关系业务类型
        /// </summary>
        [XmlElement("rel_biz_type")]
        public string RelBizType { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [XmlElement("rel_type")]
        public string RelType { get; set; }

        /// <summary>
        /// 源身份信息
        /// </summary>
        [XmlElement("source_identity_certificate")]
        public AntArchiveIdentityCertificate SourceIdentityCertificate { get; set; }

        /// <summary>
        /// 目标身份信息
        /// </summary>
        [XmlElement("target_identity_certificate")]
        public AntArchiveIdentityCertificate TargetIdentityCertificate { get; set; }
    }
}
