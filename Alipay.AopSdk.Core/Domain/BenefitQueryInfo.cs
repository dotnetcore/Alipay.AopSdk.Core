using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BenefitQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitQueryInfo : AopObject
    {
        /// <summary>
        /// 权益描述
        /// </summary>
        [XmlElement("benefit_desc")]
        public string BenefitDesc { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 权益面额
        /// </summary>
        [XmlElement("beneft_price")]
        public string BeneftPrice { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 其他信息，为key-value格式，格式为json
        /// </summary>
        [XmlElement("other_infos")]
        public string OtherInfos { get; set; }

        /// <summary>
        /// 每人限领数量
        /// </summary>
        [XmlElement("person_limit")]
        public string PersonLimit { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_quantity")]
        public string TotalQuantity { get; set; }
    }
}
