using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PosChooseDishGroupModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosChooseDishGroupModel : AopObject
    {
        /// <summary>
        /// 组合菜的ID，如果套餐有组合菜，必传
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 菜品中项目组的排序号
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }
    }
}
