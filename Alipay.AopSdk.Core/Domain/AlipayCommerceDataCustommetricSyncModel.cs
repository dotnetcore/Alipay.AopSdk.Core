using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceDataCustommetricSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataCustommetricSyncModel : AopObject
    {
        /// <summary>
        /// 自定义监控指标数据结构，商户与支付宝进行监控共建场景使用，用户按照数据结构自主上传
        /// </summary>
        [XmlArray("metric_data")]
        [XmlArrayItem("custom_metric")]
        public List<CustomMetric> MetricData { get; set; }

        /// <summary>
        /// 命名空间，商户与支付宝进行监控共建场景使用，命令空间需要先在云监控自定义监控页面配置录入。
        /// </summary>
        [XmlElement("namespace")]
        public string Namespace { get; set; }
    }
}
