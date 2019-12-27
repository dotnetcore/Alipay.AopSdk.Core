using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RefundExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class RefundExtendParams : AopObject
    {
        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        [XmlElement("credit_category_id")]
        public string CreditCategoryId { get; set; }

        /// <summary>
        /// 信用服务ID
        /// </summary>
        [XmlElement("credit_service_id")]
        public string CreditServiceId { get; set; }
    }
}
