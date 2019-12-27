using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotWifiSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotWifiSetModel : AopObject
    {
        /// <summary>
        /// 设备唯一id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 设置wifi
        /// </summary>
        [XmlElement("pwd")]
        public string Pwd { get; set; }

        /// <summary>
        /// wifi名称
        /// </summary>
        [XmlElement("ssid")]
        public string Ssid { get; set; }
    }
}
