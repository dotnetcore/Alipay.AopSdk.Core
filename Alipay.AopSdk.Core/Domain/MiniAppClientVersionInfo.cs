using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MiniAppClientVersionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppClientVersionInfo : AopObject
    {
        /// <summary>
        /// 最大客户端版本号信息
        /// </summary>
        [XmlElement("max_client_version")]
        public string MaxClientVersion { get; set; }

        /// <summary>
        /// 最小客户端版本号
        /// </summary>
        [XmlElement("min_client_version")]
        public string MinClientVersion { get; set; }
    }
}
