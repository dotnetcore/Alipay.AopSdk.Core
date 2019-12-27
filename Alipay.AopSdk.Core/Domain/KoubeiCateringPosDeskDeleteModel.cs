using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskDeleteModel : AopObject
    {
        /// <summary>
        /// 桌位Id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 门店Id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
