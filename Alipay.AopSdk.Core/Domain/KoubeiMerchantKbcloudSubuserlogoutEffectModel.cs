using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserlogoutEffectModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbcloudSubuserlogoutEffectModel : AopObject
    {
        /// <summary>
        /// 登录的sessionId
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
