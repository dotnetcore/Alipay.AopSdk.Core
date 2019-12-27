using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UboVO Data Structure.
    /// </summary>
    [Serializable]
    public class UboVO : AopObject
    {
        /// <summary>
        /// 职务
        /// </summary>
        [XmlElement("duty")]
        public string Duty { get; set; }

        /// <summary>
        /// 控股比例
        /// </summary>
        [XmlElement("invest_rate")]
        public string InvestRate { get; set; }

        /// <summary>
        /// ubo名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
