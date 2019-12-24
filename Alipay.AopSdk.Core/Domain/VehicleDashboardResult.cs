using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// VehicleDashboardResult Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleDashboardResult : AopObject
    {
        /// <summary>
        /// label每个元素对应的含义
        /// </summary>
        [XmlElement("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 识别的labels
        /// </summary>
        [XmlElement("label")]
        public long Label { get; set; }

        /// <summary>
        /// label每个元素对应的概率
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }
    }
}
