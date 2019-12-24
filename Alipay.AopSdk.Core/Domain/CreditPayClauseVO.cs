using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CreditPayClauseVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayClauseVO : AopObject
    {
        /// <summary>
        /// 合同密钥
        /// </summary>
        [XmlElement("contract_key")]
        public string ContractKey { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 合同url
        /// </summary>
        [XmlElement("contract_url")]
        public string ContractUrl { get; set; }
    }
}
