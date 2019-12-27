using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserloginstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbcloudSubuserloginstatusQueryModel : AopObject
    {
        /// <summary>
        /// 登录的sessionId；session_id或sub_user_id必须传一个
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 子账号id；session_id或sub_user_id必须传一个
        /// </summary>
        [XmlElement("sub_user_id")]
        public string SubUserId { get; set; }
    }
}
