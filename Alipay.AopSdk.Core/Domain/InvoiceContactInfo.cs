using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// InvoiceContactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceContactInfo : AopObject
    {
        /// <summary>
        /// 联系人地址
        /// </summary>
        [XmlElement("contact_addr")]
        public string ContactAddr { get; set; }

        /// <summary>
        /// 联系人邮件
        /// </summary>
        [XmlElement("contact_mail")]
        public string ContactMail { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }
    }
}
