using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringDishEstimatedSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishEstimatedSyncModel : AopObject
    {
        /// <summary>
        /// 菜品估清类型,estimated表示菜品估清
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 菜品估清对象列表
        /// </summary>
        [XmlArray("kbdish_estimated_list")]
        [XmlArrayItem("kbdish_estimated_info")]
        public List<KbdishEstimatedInfo> KbdishEstimatedList { get; set; }

        /// <summary>
        /// 同步类型,update会覆盖更新，目前只支持update
        /// </summary>
        [XmlElement("syn_type")]
        public string SynType { get; set; }
    }
}
