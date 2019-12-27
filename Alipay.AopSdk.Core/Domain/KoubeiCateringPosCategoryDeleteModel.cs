using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategoryDeleteModel : AopObject
    {
        /// <summary>
        /// 菜类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
