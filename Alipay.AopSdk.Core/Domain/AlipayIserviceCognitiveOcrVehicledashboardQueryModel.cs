using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehicledashboardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrVehicledashboardQueryModel : AopObject
    {
        /// <summary>
        /// 自定义场景字段，通过biz_name明确是那个场景，仪表板写死为 dashboard
        /// </summary>
        [XmlElement("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 仪表盘图片base64编码后内容，大小限制在1.5M
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }
    }
}
