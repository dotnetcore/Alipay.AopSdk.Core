using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MaskedUserCertView Data Structure.
    /// </summary>
    [Serializable]
    public class MaskedUserCertView : AopObject
    {
        /// <summary>
        /// 是否通过实名认证， 是 - T； 否 - F
        /// </summary>
        [XmlElement("is_certified")]
        public string IsCertified { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 脱敏后的姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
