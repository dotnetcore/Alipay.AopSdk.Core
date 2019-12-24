using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PintuanUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PintuanUserInfo : AopObject
    {
        /// <summary>
        /// 头像地址
        /// </summary>
        [XmlElement("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// havanaId
        /// </summary>
        [XmlElement("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }
    }
}
