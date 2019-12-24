using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OuterGroup Data Structure.
    /// </summary>
    [Serializable]
    public class OuterGroup : AopObject
    {
        /// <summary>
        /// 业务扩展参数字段，根据第三方需要使用，投放端只做存储并向检索端透传
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 单元出价，单位：分
        /// </summary>
        [XmlElement("group_charge")]
        public long GroupCharge { get; set; }

        /// <summary>
        /// 单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 单元名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 外部唯一单元编号
        /// </summary>
        [XmlElement("group_outer_id")]
        public string GroupOuterId { get; set; }

        /// <summary>
        /// 单元状态： ENABLE-生效 DISABLE-暂停 DELETE-已删除 INIT-初始化 REAL_DISABLE-失效
        /// </summary>
        [XmlElement("group_status")]
        public string GroupStatus { get; set; }

        /// <summary>
        /// 商品id列表
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 外部唯一计划编号
        /// </summary>
        [XmlElement("plan_outer_id")]
        public string PlanOuterId { get; set; }

        /// <summary>
        /// 单元定向列表。目前支持的定向类型有：  REGION_LIST: 实时地址  AD_POS_LIST: 广告位定向  OUTER_KOUBEI_INTEREST_TAG_LIST: 口碑偏好  OUTER_KOUBEI_CROWD_TAG_LIST：口碑人群
        /// </summary>
        [XmlArray("targeting_list")]
        [XmlArrayItem("outer_targeting_item")]
        public List<OuterTargetingItem> TargetingList { get; set; }

        /// <summary>
        /// 投放区间内的投放时段
        /// </summary>
        [XmlElement("time_option")]
        public string TimeOption { get; set; }

        /// <summary>
        /// 投放时段配置，bitmap。规则：7个int用「,」分隔组成的字符串；每个int中第0位表示0点，第1位表示1点。如此类推; 7个int的排序是星期日、星期一、星期二、星期三、星期四、星期五、星期六
        /// </summary>
        [XmlElement("time_schema")]
        public string TimeSchema { get; set; }
    }
}
