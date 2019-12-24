using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusPredictresultQueryModel : AopObject
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 预测结果对最小影响客流数的过滤
        /// </summary>
        [XmlElement("min_volume")]
        public long MinVolume { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 线路结果类型： 枚举值    0： 单向线路，  1： 双向线路。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
