using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DishList Data Structure.
    /// </summary>
    [Serializable]
    public class DishList : AopObject
    {
        /// <summary>
        /// 总价
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 口碑推单的批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 菜品优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 菜品优惠明细
        /// </summary>
        [XmlArray("discount_infos")]
        [XmlArrayItem("discount_infos")]
        public List<DiscountInfos> DiscountInfos { get; set; }

        /// <summary>
        /// 菜品在口碑侧基于商品表达的商品ID
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品类型：  可枚举：  (1)SINGLE  (2)COMBO
        /// </summary>
        [XmlElement("dish_type")]
        public string DishType { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("num")]
        public string Num { get; set; }

        /// <summary>
        /// POS侧菜品明细单ID
        /// </summary>
        [XmlElement("out_detail_id")]
        public string OutDetailId { get; set; }

        /// <summary>
        /// 外部菜品ID
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// "菜品的其他信息，包括但不限于：sku、规格，做法等信息;  为Map结构的json格式，key的枚举定义：  (1)PRACTICE:""红烧""   做法  (2)PRACTICE_PRICE:""10.0"" 做法加价  (3)SALES_PROPERTY: {""甜度"":[""五分甜"",""三分甜""],""冰量"":[""少冰""]} 一般销售属性  (4)SPECIFICATION:""大""  规格"
        /// </summary>
        [XmlElement("out_dish_infos")]
        public string OutDishInfos { get; set; }

        /// <summary>
        /// 外部菜品SKU ID
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 套餐选择信息
        /// </summary>
        [XmlArray("selected_meal_info")]
        [XmlArrayItem("selected_meal_info")]
        public List<SelectedMealInfo> SelectedMealInfo { get; set; }

        /// <summary>
        /// 商品下细分的sku ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 菜品状态：  可枚举：  (1)INIT:加菜  (2)SUCCESS:接单  (3)REFUND:退菜  (4)CLOSE:拒单
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 是否临时菜：  可枚举：  (1)Y  (2)N
        /// </summary>
        [XmlElement("temporary_dish")]
        public string TemporaryDish { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
