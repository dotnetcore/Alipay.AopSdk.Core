using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SubMerchantParams Data Structure.
    /// </summary>
    [Serializable]
    public class SubMerchantParams : AopObject
    {
        /// <summary>
        /// 子商户的商户id
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 子商户的商户名称
        /// </summary>
        [XmlElement("sub_merchant_name")]
        public string SubMerchantName { get; set; }

        /// <summary>
        /// 子商户的服务描述
        /// </summary>
        [XmlElement("sub_merchant_service_description")]
        public string SubMerchantServiceDescription { get; set; }

        /// <summary>
        /// 子商户的服务名称
        /// </summary>
        [XmlElement("sub_merchant_service_name")]
        public string SubMerchantServiceName { get; set; }
    }
}
