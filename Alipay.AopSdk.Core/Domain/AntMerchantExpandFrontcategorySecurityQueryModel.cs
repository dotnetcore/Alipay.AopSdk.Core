using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandFrontcategorySecurityQueryModel : AopObject
    {
        /// <summary>
        /// 场景码（具体值请参见产品文档）
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 前台类目归属主体ID  例：前台类目归属主体类型为店铺，则前台类目归属主体ID为店铺ID；
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 前台类目归属主体类型:  5（店铺）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
