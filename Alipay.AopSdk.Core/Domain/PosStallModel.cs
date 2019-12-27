using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PosStallModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosStallModel : AopObject
    {
        /// <summary>
        /// 菜品下档口的排序号
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 档口ID
        /// </summary>
        [XmlElement("stall_id")]
        public string StallId { get; set; }

        /// <summary>
        /// 档口名字
        /// </summary>
        [XmlElement("stall_name")]
        public string StallName { get; set; }
    }
}
