using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveCustrelationAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntarchiveCustrelationAddModel : AopObject
    {
        /// <summary>
        /// 待关联客户id
        /// </summary>
        [XmlElement("cust_id")]
        public string CustId { get; set; }

        /// <summary>
        /// 蚂蚁档案身份信息证明
        /// </summary>
        [XmlElement("identity_certificate")]
        public AntArchiveIdentityCertificate IdentityCertificate { get; set; }
    }
}
