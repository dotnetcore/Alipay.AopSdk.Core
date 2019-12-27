using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMallShopitemsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataMallShopitemsQueryModel : AopObject
    {
        /// <summary>
        /// 查询内容范围
        /// </summary>
        [XmlElement("collect_type")]
        public string CollectType { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 最多优惠券个数
        /// </summary>
        [XmlElement("max_coupons_num")]
        public string MaxCouponsNum { get; set; }

        /// <summary>
        /// 最多商品个数
        /// </summary>
        [XmlElement("max_items_num")]
        public string MaxItemsNum { get; set; }

        /// <summary>
        /// 分页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页个数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 设备版本号
        /// </summary>
        [XmlElement("product_version")]
        public string ProductVersion { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
