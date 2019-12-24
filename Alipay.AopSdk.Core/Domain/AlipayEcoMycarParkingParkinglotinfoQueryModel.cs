using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingParkinglotinfoQueryModel : AopObject
    {
        /// <summary>
        /// ISV停车场ID，由ISV定义的停车场标识，系统唯一，parking_id和out_parking_id不能同时为空
        /// </summary>
        [XmlElement("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，系统唯一, parking_id和out_parking_id不能同时为空
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
