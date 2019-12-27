using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UserLoginStatusDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UserLoginStatusDetail : AopObject
    {
        /// <summary>
        /// 口碑云子账号联系人邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 口碑云子账号联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 口碑云子账号联系人联系方式
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 口碑云子账号id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 口碑云子账号名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 口碑云子账户显示名
        /// </summary>
        [XmlElement("user_show_name")]
        public string UserShowName { get; set; }
    }
}
