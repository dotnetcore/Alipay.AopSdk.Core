using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaMerchantActivityParticipatedQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantActivityParticipatedQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID，唯一键标识用户身份。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
