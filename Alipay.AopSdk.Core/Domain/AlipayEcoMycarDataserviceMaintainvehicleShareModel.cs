using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataserviceMaintainvehicleShareModel : AopObject
    {
        /// <summary>
        /// 车辆ID
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
