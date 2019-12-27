using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CustomMetric Data Structure.
    /// </summary>
    [Serializable]
    public class CustomMetric : AopObject
    {
        /// <summary>
        /// 监控共建自定义指标数据产生的时间戳
        /// </summary>
        [XmlElement("biz_time")]
        public long BizTime { get; set; }

        /// <summary>
        /// 监控共建自定义指标维度集合
        /// </summary>
        [XmlArray("dimensions")]
        [XmlArrayItem("dimension")]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// 监控共建自定义指标名称
        /// </summary>
        [XmlElement("metric_name")]
        public string MetricName { get; set; }

        /// <summary>
        /// 监控共建自定义指标值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
