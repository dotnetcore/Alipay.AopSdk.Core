using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MStepCashRule Data Structure.
    /// </summary>
    [Serializable]
    public class MStepCashRule : AopObject
    {
        /// <summary>
        /// 优惠金额(单位:分)
        /// </summary>
        [XmlElement("reduction_amount")]
        public long ReductionAmount { get; set; }

        /// <summary>
        /// 起步金额(单位:分)
        /// </summary>
        [XmlElement("threshold_amount")]
        public long ThresholdAmount { get; set; }
    }
}
