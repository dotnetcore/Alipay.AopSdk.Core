using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MiniAppVersionQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppVersionQueryInfo : AopObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }
    }
}
