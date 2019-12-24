using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MMemberLevel Data Structure.
    /// </summary>
    [Serializable]
    public class MMemberLevel : AopObject
    {
        /// <summary>
        /// 会员等级code码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 会员等级值
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 会员等级名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
