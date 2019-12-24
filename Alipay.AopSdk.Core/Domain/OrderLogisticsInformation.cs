using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OrderLogisticsInformation Data Structure.
    /// </summary>
    [Serializable]
    public class OrderLogisticsInformation : AopObject
    {
        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("express_company")]
        public string ExpressCompany { get; set; }

        /// <summary>
        /// 是否匹配到物流单号
        /// </summary>
        [XmlElement("has_matched")]
        public bool HasMatched { get; set; }

        /// <summary>
        /// 物流状态 RECEIVE_SUCCESS-揽件成功 DELIVER_SUCCESS-快件发出 TRANSIT-中转 DELIVERY_REMIND-派件提醒 TO_PICK_UP-待提货 RECEIVE_SIGN-已签收 SIGN_FAILED-签收失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
