using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SocialInfoView Data Structure.
    /// </summary>
    [Serializable]
    public class SocialInfoView : AopObject
    {
        /// <summary>
        /// 用户头像链接，如果用户没有设置头像，则返回空
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 用户昵称，如果用户没有设置昵称，则返回空
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
