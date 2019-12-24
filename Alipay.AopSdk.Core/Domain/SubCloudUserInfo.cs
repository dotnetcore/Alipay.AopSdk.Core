using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SubCloudUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubCloudUserInfo : AopObject
    {
        /// <summary>
        /// 口碑子账号ID
        /// </summary>
        [XmlElement("sub_user_id")]
        public string SubUserId { get; set; }

        /// <summary>
        /// 口碑子账号名称
        /// </summary>
        [XmlElement("sub_user_name")]
        public string SubUserName { get; set; }

        /// <summary>
        /// 口碑子账号显示名
        /// </summary>
        [XmlElement("sub_user_show_name")]
        public string SubUserShowName { get; set; }

        /// <summary>
        /// 口碑主账号ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 口碑主账号名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
