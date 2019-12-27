using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PriceInfo : AopObject
    {
        /// <summary>
        /// 商品价格维度信息
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 价格，单位为元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
