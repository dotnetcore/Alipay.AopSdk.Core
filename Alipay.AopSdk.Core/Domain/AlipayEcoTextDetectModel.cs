using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoTextDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoTextDetectModel : AopObject
    {
        /// <summary>
        /// 检测任务列表
        /// </summary>
        [XmlArray("task")]
        [XmlArrayItem("spi_detection_task")]
        public List<SpiDetectionTask> Task { get; set; }
    }
}
