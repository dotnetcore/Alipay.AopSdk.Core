using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PromoxCrowdMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoxCrowdMatchModel : AopObject
    {
        /// <summary>
        /// 客群码
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 是否匹配
        /// </summary>
        [XmlElement("is_match")]
        public bool IsMatch { get; set; }
    }
}
