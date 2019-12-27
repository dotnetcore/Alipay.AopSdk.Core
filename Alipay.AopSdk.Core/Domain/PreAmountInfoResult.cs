using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PreAmountInfoResult Data Structure.
    /// </summary>
    [Serializable]
    public class PreAmountInfoResult : AopObject
    {
        /// <summary>
        /// 前置费用明细列表
        /// </summary>
        [XmlArray("pre_amount_list")]
        [XmlArrayItem("pre_amount_clause_result")]
        public List<PreAmountClauseResult> PreAmountList { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("total_pre_mount")]
        public string TotalPreMount { get; set; }
    }
}
