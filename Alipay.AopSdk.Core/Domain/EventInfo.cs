using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// EventInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EventInfo : AopObject
    {
        /// <summary>
        /// 设备指纹token
        /// </summary>
        [XmlElement("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 用户证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用户邮箱，用于注册保护
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 事件编码：  注册保护请填写：EC_REGISTER_NORMAL  营销保护请填写：EC_MARKETING_CAMPAIGN_NORMAL
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 事件发生时间
        /// </summary>
        [XmlElement("gmt_occur")]
        public string GmtOccur { get; set; }

        /// <summary>
        /// 用户手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 活动编号/活动交易号，用于营销保护
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 操作平台：ios/android/winphone/h5/pc/other
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 用户中文姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
