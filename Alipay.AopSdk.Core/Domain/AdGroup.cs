using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AdGroup Data Structure.
    /// </summary>
    [Serializable]
    public class AdGroup : AopObject
    {
        /// <summary>
        /// 广告系统ID
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 人群定向（优化）配置串
        /// </summary>
        [XmlElement("crowd_condition")]
        public string CrowdCondition { get; set; }

        /// <summary>
        /// 广告单元ID，新建时留空
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 广告单元名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 单元所属计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 区域定向
        /// </summary>
        [XmlArray("position_condition")]
        [XmlArrayItem("position")]
        public List<Position> PositionCondition { get; set; }

        /// <summary>
        /// 单元保量数值
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }
    }
}
