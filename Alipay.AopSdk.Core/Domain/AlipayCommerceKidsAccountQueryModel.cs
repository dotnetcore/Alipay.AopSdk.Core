using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceKidsAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceKidsAccountQueryModel : AopObject
    {
        /// <summary>
        /// 登陆名
        /// </summary>
        [XmlElement("login_name")]
        public string LoginName { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
