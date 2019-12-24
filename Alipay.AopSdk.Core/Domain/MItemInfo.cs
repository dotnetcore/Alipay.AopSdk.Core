using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MItemInfo : AopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// item_id字段说明类型，目前支持枚举：菜品：DISH，注意：菜品必须为单品菜品信息
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
