using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategorySaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategorySaveModel : AopObject
    {
        /// <summary>
        /// 排序菜类列表
        /// </summary>
        [XmlArray("category_entity_list")]
        [XmlArrayItem("dish_category_entity")]
        public List<DishCategoryEntity> CategoryEntityList { get; set; }
    }
}
