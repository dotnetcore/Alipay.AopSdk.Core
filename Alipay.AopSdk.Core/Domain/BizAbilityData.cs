using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BizAbilityData Data Structure.
    /// </summary>
    [Serializable]
    public class BizAbilityData : AopObject
    {
        /// <summary>
        /// 业务能力数据json值
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 数据key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
