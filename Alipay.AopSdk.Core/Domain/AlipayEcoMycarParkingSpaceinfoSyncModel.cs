using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingSpaceinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingSpaceinfoSyncModel : AopObject
    {
        /// <summary>
        /// 空闲充电桩车位数
        /// </summary>
        [XmlElement("free_charging_pile")]
        public long FreeChargingPile { get; set; }

        /// <summary>
        /// 车场空闲可用的车位数
        /// </summary>
        [XmlElement("free_parking_space")]
        public long FreeParkingSpace { get; set; }

        /// <summary>
        /// 停车场ID
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场实时状态: 0 拥堵,1 正常，2 空闲
        /// </summary>
        [XmlElement("parking_space_status")]
        public string ParkingSpaceStatus { get; set; }
    }
}
