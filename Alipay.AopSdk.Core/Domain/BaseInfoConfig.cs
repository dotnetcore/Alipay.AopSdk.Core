using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BaseInfoConfig Data Structure.
    /// </summary>
    [Serializable]
    public class BaseInfoConfig : AopObject
    {
        /// <summary>
        /// 商户联系人邮箱，需为合法的邮箱。
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 商户联系人电话，需为合法的电话号码。
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 信用服务logo地址，为必传字段，需为合法的链接。
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 信用服务名称，为必传字段。
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }
    }
}
