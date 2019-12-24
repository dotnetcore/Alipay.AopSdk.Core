using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthAppCancelModel : AopObject
    {
        /// <summary>
        /// 授权方应用ID
        /// </summary>
        [XmlElement("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 授权场景，固定值PLATFORM_APP_AUTH
        /// </summary>
        [XmlElement("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 当前登录账号支付宝userId
        /// </summary>
        [XmlElement("operator_user_id")]
        public string OperatorUserId { get; set; }
    }
}
