using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ShopExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopExtInfo : AopObject
    {
        /// <summary>
        /// KV数据对的key，表示该kv对象表示什么含义。
        /// </summary>
        [XmlElement("key_name")]
        public string KeyName { get; set; }

        /// <summary>
        /// kv对象的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
