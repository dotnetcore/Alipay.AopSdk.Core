using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringDishMaterialCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishMaterialCreateModel : AopObject
    {
        /// <summary>
        /// 菜品加料入参
        /// </summary>
        [XmlElement("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
