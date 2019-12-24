using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserAdCreateModel : AopObject
    {
        /// <summary>
        /// 定向的设备sn列表
        /// </summary>
        [XmlArray("device_sn_list")]
        [XmlArrayItem("string")]
        public List<string> DeviceSnList { get; set; }

        /// <summary>
        /// 设备类型，qt:蜻蜓
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 投放结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 广告位值，静默页：idle
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("material_id")]
        public long MaterialId { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 投放开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
