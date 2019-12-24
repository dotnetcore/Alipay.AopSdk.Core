using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CreditPayChargePricingVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayChargePricingVO : AopObject
    {
        /// <summary>
        /// 实际费用，单位元
        /// </summary>
        [XmlElement("actual_charge")]
        public string ActualCharge { get; set; }

        /// <summary>
        /// 实际费率，小数形式
        /// </summary>
        [XmlElement("actual_charge_rate")]
        public string ActualChargeRate { get; set; }

        /// <summary>
        /// 费用名目
        /// </summary>
        [XmlElement("charge_name")]
        public string ChargeName { get; set; }

        /// <summary>
        /// 原始费用，单位元
        /// </summary>
        [XmlElement("origin_charge")]
        public string OriginCharge { get; set; }

        /// <summary>
        /// 原始费率，小数形式
        /// </summary>
        [XmlElement("origin_charge_rate")]
        public string OriginChargeRate { get; set; }
    }
}
