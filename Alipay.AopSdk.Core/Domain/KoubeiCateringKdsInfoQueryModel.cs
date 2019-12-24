using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringKdsInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringKdsInfoQueryModel : AopObject
    {
        /// <summary>
        /// kdsID
        /// </summary>
        [XmlElement("kds_id")]
        public string KdsId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
