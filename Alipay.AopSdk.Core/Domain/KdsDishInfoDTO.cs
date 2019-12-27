using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KdsDishInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class KdsDishInfoDTO : AopObject
    {
        /// <summary>
        /// 菜品制作耗时，单位分钟
        /// </summary>
        [XmlElement("cook_cost")]
        public long CookCost { get; set; }

        /// <summary>
        /// 菜品组信息：套餐内单品、单品加料
        /// </summary>
        [XmlArray("dish_group_info")]
        [XmlArrayItem("kds_dish_group_info_d_t_o")]
        public List<KdsDishGroupInfoDTO> DishGroupInfo { get; set; }

        /// <summary>
        /// 口碑菜品ID
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 口碑菜品skuID
        /// </summary>
        [XmlElement("dish_sku_id")]
        public string DishSkuId { get; set; }

        /// <summary>
        /// 菜品单位
        /// </summary>
        [XmlElement("dish_unit")]
        public string DishUnit { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 菜品一次性可制作最大份数
        /// </summary>
        [XmlElement("max_cook_num")]
        public long MaxCookNum { get; set; }

        /// <summary>
        /// 菜品备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部菜品ID
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部菜品信息(JSON格式)
        /// </summary>
        [XmlElement("out_dish_info")]
        public string OutDishInfo { get; set; }

        /// <summary>
        /// 外部菜品skuID
        /// </summary>
        [XmlElement("out_dish_sku_id")]
        public string OutDishSkuId { get; set; }

        /// <summary>
        /// 做法描述
        /// </summary>
        [XmlElement("practice_desc")]
        public string PracticeDesc { get; set; }

        /// <summary>
        /// 做法ID
        /// </summary>
        [XmlElement("practice_id")]
        public string PracticeId { get; set; }

        /// <summary>
        /// 菜品数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 销售属性 (预留字段)
        /// </summary>
        [XmlElement("sales_properties")]
        public string SalesProperties { get; set; }

        /// <summary>
        /// sku规格描述
        /// </summary>
        [XmlElement("sku_spec_desc")]
        public string SkuSpecDesc { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [XmlElement("spec_id")]
        public string SpecId { get; set; }

        /// <summary>
        /// 菜品类型. "SINGLE": 单品; "SIDE": 加料; "COMBO": 套餐"; "COMBO_SINGLE": 套餐内单品  type 校验规则: 1. 单品/加料 type=SINGLE/SIDE 2. 套餐: 一级type=COMBO, dish_group_info里的子菜type=COMBO_SINGLE 3. 无法同步到口碑的套餐 (只能打平后同步). type=COMBO_SINGLE  套餐/加料的type例子: 1. 普通菜加料: 一级SINGLE; 二级SIDE. 2. 套餐 子菜不加料: 一级COMBO; 二级COMBO_SINGLE. 3. 套餐 子菜加料: 一级COMBO; 二级COMBO_SINGLE 或 SIDE + out_parent_id.
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
