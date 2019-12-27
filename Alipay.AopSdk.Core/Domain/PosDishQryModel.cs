using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PosDishQryModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosDishQryModel : AopObject
    {
        /// <summary>
        /// 菜品类别
        /// </summary>
        [XmlElement("category_big_id")]
        public string CategoryBigId { get; set; }

        /// <summary>
        /// 菜品类别中文名
        /// </summary>
        [XmlElement("category_big_name")]
        public string CategoryBigName { get; set; }

        /// <summary>
        /// 组合菜的列表
        /// </summary>
        [XmlArray("choose_dish_group_list")]
        [XmlArrayItem("pos_dish_group_model")]
        public List<PosDishGroupModel> ChooseDishGroupList { get; set; }

        /// <summary>
        /// 菜品的ID
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品图片素材库ID
        /// </summary>
        [XmlElement("dish_img")]
        public string DishImg { get; set; }

        /// <summary>
        /// 菜品的名字
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 拼音助记码
        /// </summary>
        [XmlElement("en_remember_code")]
        public string EnRememberCode { get; set; }

        /// <summary>
        /// 固定菜列表
        /// </summary>
        [XmlArray("fixed_dish_group_list")]
        [XmlArrayItem("pos_fixed_dish_group_model")]
        public List<PosFixedDishGroupModel> FixedDishGroupList { get; set; }

        /// <summary>
        /// 制作时长，单位：秒
        /// </summary>
        [XmlElement("making_time")]
        public long MakingTime { get; set; }

        /// <summary>
        /// 配菜列表
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("pos_dish_material_model")]
        public List<PosDishMaterialModel> MaterialList { get; set; }

        /// <summary>
        /// 单次最大制作份数
        /// </summary>
        [XmlElement("max_copies_per_time")]
        public long MaxCopiesPerTime { get; set; }

        /// <summary>
        /// 最小份数
        /// </summary>
        [XmlElement("min_serving")]
        public long MinServing { get; set; }

        /// <summary>
        /// 数字助记码
        /// </summary>
        [XmlElement("nb_remember_code")]
        public string NbRememberCode { get; set; }

        /// <summary>
        /// 菜品做法列表
        /// </summary>
        [XmlArray("practice_list")]
        [XmlArrayItem("pos_dish_practice_model")]
        public List<PosDishPracticeModel> PracticeList { get; set; }

        /// <summary>
        /// 菜品描述
        /// </summary>
        [XmlElement("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("pos_sku_model")]
        public List<PosSkuModel> SkuList { get; set; }

        /// <summary>
        /// 档口列表
        /// </summary>
        [XmlArray("stall_list")]
        [XmlArrayItem("pos_stall_model")]
        public List<PosStallModel> StallList { get; set; }

        /// <summary>
        /// 菜品的售卖状态  open 起售  stop 停售
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 菜品标签
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 菜品大类
        /// </summary>
        [XmlElement("type_big")]
        public string TypeBig { get; set; }

        /// <summary>
        /// 菜品小类
        /// </summary>
        [XmlElement("type_small")]
        public string TypeSmall { get; set; }

        /// <summary>
        /// 菜品单位
        /// </summary>
        [XmlElement("unit_name")]
        public string UnitName { get; set; }
    }
}
