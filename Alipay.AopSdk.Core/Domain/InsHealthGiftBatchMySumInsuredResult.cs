using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// InsHealthGiftBatchMySumInsuredResult Data Structure.
    /// </summary>
    [Serializable]
    public class InsHealthGiftBatchMySumInsuredResult : AopObject
    {
        /// <summary>
        /// 业务类型。免费医疗金 HEALTH_BEAN_SIMPLE_UPGRADE、守护金 HEALTH_GUARDIAN_GOLD、多收多宝新门诊 HEALTH_DSDB_NEW_OUTPATIENT
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 总保额
        /// </summary>
        [XmlElement("sum_insured")]
        public string SumInsured { get; set; }
    }
}
