using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ItemLabelCreateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemLabelCreateInfo : AopObject
    {
        /// <summary>
        /// 标签键  OIL_NUM：油号
        /// </summary>
        [XmlElement("label_key")]
        public string LabelKey { get; set; }

        /// <summary>
        /// 标签值：  OIL_NUM对应的值为：95# 92# 98# 等等
        /// </summary>
        [XmlElement("label_value")]
        public string LabelValue { get; set; }
    }
}
