using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AppBasicInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AppBasicInfoResponse : AopObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("open_app_id")]
        public string OpenAppId { get; set; }

        /// <summary>
        /// 应用的名称
        /// </summary>
        [XmlElement("open_app_name")]
        public string OpenAppName { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [XmlElement("open_app_type")]
        public string OpenAppType { get; set; }
    }
}
