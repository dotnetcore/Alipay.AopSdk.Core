using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsDataDsbEstimateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDsbEstimateQueryModel : AopObject
    {
        /// <summary>
        /// 定损单号
        /// </summary>
        [XmlElement("estimate_no")]
        public string EstimateNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [XmlElement("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 修理厂类型，枚举如下。    4S－4S店  GENERAL－综合修理厂
        /// </summary>
        [XmlElement("garage_type")]
        public string GarageType { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("license_no")]
        public string LicenseNo { get; set; }
    }
}
