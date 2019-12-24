using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointPointprodBudgetlibModifyModel : AopObject
    {
        /// <summary>
        /// 预算库编码
        /// </summary>
        [XmlElement("budget_code")]
        public string BudgetCode { get; set; }

        /// <summary>
        /// 积分库对应的签约协议id
        /// </summary>
        [XmlElement("contract_pid")]
        public string ContractPid { get; set; }

        /// <summary>
        /// 预算库有效期 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 预算库对应的积分库ID
        /// </summary>
        [XmlElement("point_lib_id")]
        public string PointLibId { get; set; }

        /// <summary>
        /// 预算库有效期 起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
