using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OnlineInviteNewerDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OnlineInviteNewerDetailInfo : AopObject
    {
        /// <summary>
        /// 用户首登/回流时间
        /// </summary>
        [XmlElement("fst_login_time")]
        public string FstLoginTime { get; set; }

        /// <summary>
        /// 绑定时间
        /// </summary>
        [XmlElement("invite_time")]
        public string InviteTime { get; set; }

        /// <summary>
        /// 被邀请手机号
        /// </summary>
        [XmlElement("invited_phone")]
        public string InvitedPhone { get; set; }

        /// <summary>
        /// 二级渠道
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 一级渠道
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 用户实名时间
        /// </summary>
        [XmlElement("user_cert_time")]
        public string UserCertTime { get; set; }
    }
}
