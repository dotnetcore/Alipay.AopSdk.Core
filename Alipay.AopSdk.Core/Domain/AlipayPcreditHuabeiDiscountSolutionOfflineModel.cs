using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiDiscountSolutionOfflineModel : AopObject
    {
        /// <summary>
        /// solution_id，贴息方案实例id
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }
    }
}
