using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SpiDetectionTask Data Structure.
    /// </summary>
    [Serializable]
    public class SpiDetectionTask : AopObject
    {
        /// <summary>
        /// 待检测文本内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 检测任务编号
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }
    }
}
