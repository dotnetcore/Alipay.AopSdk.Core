using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MPromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MPromoInfo : AopObject
    {
        /// <summary>
        /// 活动预算信息
        /// </summary>
        [XmlElement("budget")]
        public MBudgetInfo Budget { get; set; }

        /// <summary>
        /// 活动限制信息
        /// </summary>
        [XmlElement("constraint")]
        public MPromoConstraint Constraint { get; set; }

        /// <summary>
        /// 活动发送的权益信息
        /// </summary>
        [XmlElement("equity_info")]
        public MEquityInfo EquityInfo { get; set; }

        /// <summary>
        /// 扩展信息字段
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("m_ext_info")]
        public List<MExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 外部活动业务id，注意：修改的时候会通过指定id进行修改，如果指定out_promo_id口碑本地无数据，进行新增，否则进行修改，如果要删除对应promo_info数据，则不需要传递promo_info数据即可。
        /// </summary>
        [XmlElement("out_promo_id")]
        public string OutPromoId { get; set; }
    }
}
