using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishbatchDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishbatchDeleteModel : AopObject
    {
        /// <summary>
        /// 菜谱的ID。用于删除菜谱中的菜品
        /// </summary>
        [XmlElement("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品ID
        /// </summary>
        [XmlArray("dish_ids")]
        [XmlArrayItem("string")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
