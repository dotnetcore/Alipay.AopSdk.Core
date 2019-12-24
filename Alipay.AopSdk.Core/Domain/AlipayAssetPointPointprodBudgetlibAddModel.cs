using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointPointprodBudgetlibAddModel : AopObject
    {
        /// <summary>
        /// 预算库追加的积分数
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 预算库编码
        /// </summary>
        [XmlElement("budget_code")]
        public string BudgetCode { get; set; }

        /// <summary>
        /// 积分库对应的签约协议Pid
        /// </summary>
        [XmlElement("contract_pid")]
        public string ContractPid { get; set; }

        /// <summary>
        /// 预算库追加备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 预算库追加操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 业务号，用于保证幂等
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 预算库对应的积分库ID
        /// </summary>
        [XmlElement("point_lib_id")]
        public string PointLibId { get; set; }
    }
}
