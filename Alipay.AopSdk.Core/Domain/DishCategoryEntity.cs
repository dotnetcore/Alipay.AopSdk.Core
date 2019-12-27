using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DishCategoryEntity Data Structure.
    /// </summary>
    [Serializable]
    public class DishCategoryEntity : AopObject
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [XmlElement("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }
    }
}
