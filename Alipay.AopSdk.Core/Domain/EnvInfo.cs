using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// EnvInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnvInfo : AopObject
    {
        /// <summary>
        /// 商户的操作员编号
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户门店Id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 商户的终端编号
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }
    }
}
