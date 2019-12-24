using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringDishConditionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishConditionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 分类字典大类的id
        /// </summary>
        [XmlElement("catetory_big_id")]
        public string CatetoryBigId { get; set; }

        /// <summary>
        /// 小类,商家自定义配置表例如 肉，酒水，素菜
        /// </summary>
        [XmlElement("catetory_small_id")]
        public string CatetorySmallId { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜名
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 商户的支付宝user_id. 商户授权后,isv能获得
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 查询页码，表示第几页
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，表示每页查询数量，不超过50
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
