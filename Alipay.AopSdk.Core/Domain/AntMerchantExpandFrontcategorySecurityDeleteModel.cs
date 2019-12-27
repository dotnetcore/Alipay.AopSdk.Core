using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandFrontcategorySecurityDeleteModel : AopObject
    {
        /// <summary>
        /// 前台类目ID
        /// </summary>
        [XmlElement("front_category_id")]
        public string FrontCategoryId { get; set; }
    }
}
