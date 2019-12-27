using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OuterTargetingItem Data Structure.
    /// </summary>
    [Serializable]
    public class OuterTargetingItem : AopObject
    {
        /// <summary>
        /// 定向类型：  REGION_LIST: 实时地址  AD_POS_LIST: 广告位定向  OUTER_KOUBEI_INTEREST_TAG_LIST: 口碑偏好  OUTER_KOUBEI_CROWD_TAG_LIST：口碑人群
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 定向值
        /// </summary>
        [XmlArray("value_list")]
        [XmlArrayItem("string")]
        public List<string> ValueList { get; set; }
    }
}
