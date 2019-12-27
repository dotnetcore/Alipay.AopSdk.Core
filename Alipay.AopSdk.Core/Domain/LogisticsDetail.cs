using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// LogisticsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsDetail : AopObject
    {
        /// <summary>
        /// 物流类型,   POST 平邮,  EXPRESS 其他快递,  VIRTUAL 虚拟物品,  EMS EMS,  DIRECT 无需物流。
        /// </summary>
        [XmlElement("logistics_type")]
        public string LogisticsType { get; set; }
    }
}
