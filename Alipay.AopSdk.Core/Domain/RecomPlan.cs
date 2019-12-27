using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RecomPlan Data Structure.
    /// </summary>
    [Serializable]
    public class RecomPlan : AopObject
    {
        /// <summary>
        /// 投保key关键字
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 方案名称，展示用
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户选择后投保带的对象
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
