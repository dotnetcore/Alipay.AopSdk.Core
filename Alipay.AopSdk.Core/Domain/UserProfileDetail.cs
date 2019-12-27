using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UserProfileDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UserProfileDetail : AopObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户发行主体;  ALIPAY:支付宝,TAOBAO:淘宝,MERCHANT:商户(星巴克)
        /// </summary>
        [XmlElement("user_issuer")]
        public string UserIssuer { get; set; }
    }
}
