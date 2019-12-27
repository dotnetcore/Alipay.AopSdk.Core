using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiItemExtitemInfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemInfoDeleteModel : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
