using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditLoanapplySmartcountyLoaninfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplySmartcountyLoaninfoQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
