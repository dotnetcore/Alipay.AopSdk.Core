using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ExtitemDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExtitemDetailInfo : AopObject
    {
        /// <summary>
        /// 标品id
        /// </summary>
        [XmlElement("extitem_id")]
        public string ExtitemId { get; set; }

        /// <summary>
        /// 标品名称
        /// </summary>
        [XmlElement("extitem_name")]
        public string ExtitemName { get; set; }

        /// <summary>
        /// 标品的货品组成
        /// </summary>
        [XmlArray("goods_component_list")]
        [XmlArrayItem("goods_component")]
        public List<GoodsComponent> GoodsComponentList { get; set; }
    }
}
