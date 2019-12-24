using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Command Data Structure.
    /// </summary>
    [Serializable]
    public class Command : AopObject
    {
        /// <summary>
        /// 下发者
        /// </summary>
        [XmlElement("commander")]
        public string Commander { get; set; }

        /// <summary>
        /// 键:值
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 执行者
        /// </summary>
        [XmlElement("executor")]
        public string Executor { get; set; }

        /// <summary>
        /// bean.method
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
