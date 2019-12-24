using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KbAdvertQuotaCommissionClause Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertQuotaCommissionClause : AopObject
    {
        /// <summary>
        /// 固定金额
        /// </summary>
        [XmlElement("quota_amount")]
        public string QuotaAmount { get; set; }
    }
}
