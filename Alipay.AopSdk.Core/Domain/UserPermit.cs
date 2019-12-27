using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UserPermit Data Structure.
    /// </summary>
    [Serializable]
    public class UserPermit : AopObject
    {
        /// <summary>
        /// 用户授权接收消息状态
        /// </summary>
        [XmlElement("permit_status")]
        public string PermitStatus { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
