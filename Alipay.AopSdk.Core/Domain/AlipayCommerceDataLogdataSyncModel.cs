using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceDataLogdataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataLogdataSyncModel : AopObject
    {
        /// <summary>
        /// 商户自定义监控原始日志数据
        /// </summary>
        [XmlElement("log")]
        public string Log { get; set; }

        /// <summary>
        /// 命名空间，商户与支付宝进行监控共建场景使用，命令空间需要先在云监控自定义监控页面配置录入。
        /// </summary>
        [XmlElement("namespace")]
        public string Namespace { get; set; }
    }
}
