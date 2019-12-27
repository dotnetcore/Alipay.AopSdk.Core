using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ItemBo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemBo : AopObject
    {
        /// <summary>
        /// json 字符串表示额外信息
        /// </summary>
        [XmlElement("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// logo链接
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [XmlElement("origin_price")]
        public long OriginPrice { get; set; }

        /// <summary>
        /// 现价
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }
    }
}
