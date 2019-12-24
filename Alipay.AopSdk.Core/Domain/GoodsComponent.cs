using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// GoodsComponent Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsComponent : AopObject
    {
        /// <summary>
        /// 货品code
        /// </summary>
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 货品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 组成数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }
    }
}
