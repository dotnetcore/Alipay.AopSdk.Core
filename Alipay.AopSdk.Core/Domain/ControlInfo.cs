using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ControlInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ControlInfo : AopObject
    {
        /// <summary>
        /// 订单超时时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
