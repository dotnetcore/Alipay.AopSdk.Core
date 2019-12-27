using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMerchantDeviceCrashinfoUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantDeviceCrashinfoUploadModel : AopObject
    {
        /// <summary>
        /// Crash事件发生时间
        /// </summary>
        [XmlElement("event_time")]
        public string EventTime { get; set; }

        /// <summary>
        /// 扩展信息(JSON格式)
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("hardware_version")]
        public string HardwareVersion { get; set; }

        /// <summary>
        /// 日志上报时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [XmlElement("log_time")]
        public string LogTime { get; set; }

        /// <summary>
        /// 消息类型 CRASH_MSG/SSIDS_MSG
        /// </summary>
        [XmlElement("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// 第三方应用的app_id
        /// </summary>
        [XmlElement("product")]
        public string Product { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("sn_id")]
        public string SnId { get; set; }
    }
}
