using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MiniAppCategory Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppCategory : AopObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 是否有子类目
        /// </summary>
        [XmlElement("has_child")]
        public bool HasChild { get; set; }

        /// <summary>
        /// 是否需要营业执照
        /// </summary>
        [XmlElement("need_license")]
        public bool NeedLicense { get; set; }

        /// <summary>
        /// 是否需要门头照
        /// </summary>
        [XmlElement("need_out_door_pic")]
        public bool NeedOutDoorPic { get; set; }

        /// <summary>
        /// 是否需要营业执照
        /// </summary>
        [XmlElement("need_special_license")]
        public bool NeedSpecialLicense { get; set; }

        /// <summary>
        /// 父类目id
        /// </summary>
        [XmlElement("parent_category_id")]
        public string ParentCategoryId { get; set; }
    }
}
