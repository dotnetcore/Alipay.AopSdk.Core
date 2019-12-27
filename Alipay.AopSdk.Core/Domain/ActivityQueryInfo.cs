using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ActivityQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityQueryInfo : AopObject
    {
        /// <summary>
        /// 新用户活动模版
        /// </summary>
        [XmlElement("new_user_template")]
        public string NewUserTemplate { get; set; }

        /// <summary>
        /// 老用户活动模版
        /// </summary>
        [XmlElement("old_user_template")]
        public string OldUserTemplate { get; set; }

        /// <summary>
        /// 查询的小程序id
        /// </summary>
        [XmlElement("query_app_id")]
        public string QueryAppId { get; set; }
    }
}
