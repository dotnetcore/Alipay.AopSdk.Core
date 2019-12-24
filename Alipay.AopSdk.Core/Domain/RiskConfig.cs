using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RiskConfig Data Structure.
    /// </summary>
    [Serializable]
    public class RiskConfig : AopObject
    {
        /// <summary>
        /// 类目风控信息列表，为必传字段。此字段为复杂模型，其中类目code为必传属性。
        /// </summary>
        [XmlArray("category_risks")]
        [XmlArrayItem("category_risk_info")]
        public List<CategoryRiskInfo> CategoryRisks { get; set; }

        /// <summary>
        /// 全局分段限额配置
        /// </summary>
        [XmlElement("quota_gradient_rule")]
        public QuotaGradientRule QuotaGradientRule { get; set; }
    }
}
