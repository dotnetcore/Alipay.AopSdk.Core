using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceKidsAccountConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceKidsAccountConsultModel : AopObject
    {
        /// <summary>
        /// 与child_cert_type对应，如果child_cert_type为IDENTITY_CARD，对应的取值为身份证号
        /// </summary>
        [XmlElement("child_cert_no")]
        public string ChildCertNo { get; set; }

        /// <summary>
        /// 证件类型，暂时只支持身份证
        /// </summary>
        [XmlElement("child_cert_type")]
        public string ChildCertType { get; set; }

        /// <summary>
        /// 信息来源，用于指定一个小宝账户
        /// </summary>
        [XmlElement("info_source")]
        public InfoSource InfoSource { get; set; }

        /// <summary>
        /// 家长支付宝userId，用于查询与该家长关联的孩子
        /// </summary>
        [XmlElement("parent_uid")]
        public string ParentUid { get; set; }

        /// <summary>
        /// 场景码，接入前需要进行申请
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
