using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PreAmountClauseResult Data Structure.
    /// </summary>
    [Serializable]
    public class PreAmountClauseResult : AopObject
    {
        /// <summary>
        /// 具体的金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 用于指定金额的描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }
    }
}
