using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ShieldDishList Data Structure.
    /// </summary>
    [Serializable]
    public class ShieldDishList : AopObject
    {
        /// <summary>
        /// 菜品ID
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 菜品数量
        /// </summary>
        [XmlElement("num")]
        public string Num { get; set; }

        /// <summary>
        /// 菜品下细分的sku ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
