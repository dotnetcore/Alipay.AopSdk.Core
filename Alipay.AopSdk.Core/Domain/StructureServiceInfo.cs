using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StructureServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StructureServiceInfo : AopObject
    {
        /// <summary>
        /// 是否提供酒精饮料
        /// </summary>
        [XmlElement("alcohol")]
        public bool Alcohol { get; set; }

        /// <summary>
        /// 是否接受预约
        /// </summary>
        [XmlElement("booking")]
        public bool Booking { get; set; }

        /// <summary>
        /// 是否有包厢
        /// </summary>
        [XmlElement("box")]
        public bool Box { get; set; }

        /// <summary>
        /// 是否允许自带杯
        /// </summary>
        [XmlElement("byo")]
        public bool Byo { get; set; }

        /// <summary>
        /// 是否提供中文服务
        /// </summary>
        [XmlElement("chinese_svc")]
        public bool ChineseSvc { get; set; }

        /// <summary>
        /// 是否有停车位
        /// </summary>
        [XmlElement("parking")]
        public bool Parking { get; set; }

        /// <summary>
        /// 是否支持外带
        /// </summary>
        [XmlElement("takeout")]
        public bool Takeout { get; set; }

        /// <summary>
        /// 是否支持电话预定
        /// </summary>
        [XmlElement("tel_rsvt")]
        public bool TelRsvt { get; set; }

        /// <summary>
        /// 是否需要小费
        /// </summary>
        [XmlElement("tips")]
        public bool Tips { get; set; }

        /// <summary>
        /// 是否有wifi
        /// </summary>
        [XmlElement("wifi")]
        public bool Wifi { get; set; }
    }
}
