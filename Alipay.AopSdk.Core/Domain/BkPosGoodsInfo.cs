using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BkPosGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BkPosGoodsInfo : AopObject
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品金额
        /// </summary>
        [XmlElement("goods_price")]
        public string GoodsPrice { get; set; }
    }
}
