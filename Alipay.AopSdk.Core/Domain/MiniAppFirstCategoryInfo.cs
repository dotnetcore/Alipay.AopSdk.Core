using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MiniAppFirstCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppFirstCategoryInfo : AopObject
    {
        /// <summary>
        /// 旅行住宿
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 小程序类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 二级类目列表
        /// </summary>
        [XmlArray("child_category")]
        [XmlArrayItem("mini_app_second_category_info")]
        public List<MiniAppSecondCategoryInfo> ChildCategory { get; set; }
    }
}
