using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CreationPlanData Data Structure.
    /// </summary>
    [Serializable]
    public class CreationPlanData : AopObject
    {
        /// <summary>
        /// 定向的设备sn列表
        /// </summary>
        [XmlArray("device_sn_list")]
        [XmlArrayItem("string")]
        public List<string> DeviceSnList { get; set; }

        /// <summary>
        /// 投放结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 投放的物料地址
        /// </summary>
        [XmlElement("material_url")]
        public string MaterialUrl { get; set; }

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

        /// <summary>
        /// 投放计划状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
