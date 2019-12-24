using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// EntityPriorRiskVO Data Structure.
    /// </summary>
    [Serializable]
    public class EntityPriorRiskVO : AopObject
    {
        /// <summary>
        /// 风险处置源
        /// </summary>
        [XmlElement("dispose_department")]
        public string DisposeDepartment { get; set; }

        /// <summary>
        /// 风险详情
        /// </summary>
        [XmlElement("risk_detail")]
        public string RiskDetail { get; set; }

        /// <summary>
        /// 风险级别
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险场景
        /// </summary>
        [XmlElement("risk_scene")]
        public string RiskScene { get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [XmlElement("risk_type")]
        public string RiskType { get; set; }
    }
}
