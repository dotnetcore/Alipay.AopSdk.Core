using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceGeofenceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceGeofenceQueryModel : AopObject
    {
        /// <summary>
        /// 一组地理围栏的唯一标识, 通常一条公交线路.
        /// </summary>
        [XmlElement("route_code")]
        public string RouteCode { get; set; }
    }
}
