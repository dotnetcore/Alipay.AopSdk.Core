using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UseRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UseRuleInfo : AopObject
    {
        /// <summary>
        /// 适用门店列表
        /// </summary>
        [XmlArray("suitable_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitableShops { get; set; }

        /// <summary>
        /// 核销方式
        /// </summary>
        [XmlArray("use_mode")]
        [XmlArrayItem("string")]
        public List<string> UseMode { get; set; }
    }
}
