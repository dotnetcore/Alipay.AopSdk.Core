using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandItemSecurityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemSecurityQueryModel : AopObject
    {
        /// <summary>
        /// 前台类目ID
        /// </summary>
        [XmlElement("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 场景码（具体值请参见产品文档）
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品状态：EFFECT（有效）、INVALID（无效）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品归属主体ID  例：商品归属主体类型为店铺，则商品归属主体ID为店铺ID；
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型：  5（店铺）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
