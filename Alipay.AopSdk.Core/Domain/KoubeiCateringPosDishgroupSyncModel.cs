using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishgroupSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishgroupSyncModel : AopObject
    {
        /// <summary>
        /// 组合菜详情
        /// </summary>
        [XmlElement("pos_dish_group_model")]
        public PosDishGroupModel PosDishGroupModel { get; set; }
    }
}
