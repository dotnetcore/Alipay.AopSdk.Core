using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AliosOpenAutoInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AliosOpenAutoInfoQueryModel : AopObject
    {
        /// <summary>
        /// 设备token
        /// </summary>
        [XmlElement("device_token")]
        public string DeviceToken { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
