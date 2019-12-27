using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ActivityStat Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityStat : AopObject
    {
        /// <summary>
        /// 活动总参与人次, 即活动总共签署合约数
        /// </summary>
        [XmlElement("contract_count")]
        public long ContractCount { get; set; }

        /// <summary>
        /// 已完成的合约数(人次)
        /// </summary>
        [XmlElement("finished_count")]
        public long FinishedCount { get; set; }

        /// <summary>
        /// 已失效的合约数(人次)
        /// </summary>
        [XmlElement("lose_efficacy_count")]
        public long LoseEfficacyCount { get; set; }

        /// <summary>
        /// 活动总参与人数
        /// </summary>
        [XmlElement("participator_count")]
        public long ParticipatorCount { get; set; }

        /// <summary>
        /// 待守约的合约数(人次)
        /// </summary>
        [XmlElement("promising_count")]
        public long PromisingCount { get; set; }

        /// <summary>
        /// 活动总履约数, 即总核销次数
        /// </summary>
        [XmlElement("trade_count")]
        public long TradeCount { get; set; }

        /// <summary>
        /// 已逾期的合约数(人次)
        /// </summary>
        [XmlElement("violated_count")]
        public long ViolatedCount { get; set; }
    }
}
