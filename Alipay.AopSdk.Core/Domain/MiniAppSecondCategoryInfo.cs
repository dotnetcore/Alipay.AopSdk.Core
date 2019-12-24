using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MiniAppSecondCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppSecondCategoryInfo : AopObject
    {
        /// <summary>
        /// 小程序类目Id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 度假用别墅服务
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }
    }
}
