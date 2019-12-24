using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MiniVersionBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniVersionBaseInfo : AopObject
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序所属来源
        /// </summary>
        [XmlElement("build_source")]
        public string BuildSource { get; set; }

        /// <summary>
        /// com.alipay.alipaywallet:支付宝，com.amap.app:高德
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序开发者ID
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 小程序灰度值
        /// </summary>
        [XmlElement("gray_strategy")]
        public string GrayStrategy { get; set; }

        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
