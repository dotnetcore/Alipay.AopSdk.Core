using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DeviceTradeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceTradeResponse : AopObject
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 设备sn，通常置于设备标签中
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 交易错误提示  例如：未收录设备的SDK交易
        /// </summary>
        [XmlElement("iot_trade_error_type")]
        public string IotTradeErrorType { get; set; }

        /// <summary>
        /// 物料id,由支付宝同学提供
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// SDK加签名信息
        /// </summary>
        [XmlElement("terminal_sdk_sign_info")]
        public string TerminalSdkSignInfo { get; set; }

        /// <summary>
        /// 交易完成时间
        /// </summary>
        [XmlElement("trade_finish_time")]
        public string TradeFinishTime { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
