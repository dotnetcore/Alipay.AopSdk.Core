using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PosCookDishCateModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosCookDishCateModel : AopObject
    {
        /// <summary>
        /// 菜类下的菜品数量
        /// </summary>
        [XmlElement("cate_dish_num")]
        public long CateDishNum { get; set; }

        /// <summary>
        /// 菜类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 菜类的名字
        /// </summary>
        [XmlElement("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 菜类的排序号
        /// </summary>
        [XmlElement("cate_sort")]
        public long CateSort { get; set; }
    }
}
