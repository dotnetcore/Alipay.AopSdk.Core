using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AftFinsecureRiskplusSecurityPolicyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AftFinsecureRiskplusSecurityPolicyQueryModel : AopObject
    {
        /// <summary>
        /// 蚁盾事件信息
        /// </summary>
        [XmlElement("event_info")]
        public EventInfo EventInfo { get; set; }

        /// <summary>
        /// 产品集群ID，默认填写示例值
        /// </summary>
        [XmlElement("product_instance_id")]
        public string ProductInstanceId { get; set; }
    }
}
