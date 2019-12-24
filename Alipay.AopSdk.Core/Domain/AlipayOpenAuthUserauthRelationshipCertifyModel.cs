using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationshipCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthUserauthRelationshipCertifyModel : AopObject
    {
        /// <summary>
        /// 操作接口名字
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
