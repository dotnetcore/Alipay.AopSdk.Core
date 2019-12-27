using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserUseridBymobileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserUseridBymobileQueryModel : AopObject
    {
        /// <summary>
        /// 手机号码，大陆的目前是11位手机号码；海外的是国家码、横杠和号码，如1-123123123
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户类型：1 - 企业类型； 2 - 个人类型。 按照所传内容进行过滤，如果不传则不过滤。
        /// </summary>
        [XmlElement("user_type")]
        public long UserType { get; set; }
    }
}
