using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategoryCreateModel : AopObject
    {
        /// <summary>
        /// 菜类名称
        /// </summary>
        [XmlElement("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
