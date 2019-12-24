using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiRetailExtitemShopextitemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailExtitemShopextitemQueryModel : AopObject
    {
        /// <summary>
        /// 查询页码，表示第几页，不传默认1
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，表示每页查询数量，不传默认10
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
