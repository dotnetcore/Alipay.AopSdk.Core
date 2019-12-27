using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAccountAliyunUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAccountAliyunUnbindModel : AopObject
    {
        /// <summary>
        /// 与阿里云账号绑定的第三方平台的账号ID
        /// </summary>
        [XmlElement("bind_id")]
        public string BindId { get; set; }

        /// <summary>
        /// Havana绑定站点
        /// </summary>
        [XmlElement("havana_bind_station")]
        public string HavanaBindStation { get; set; }

        /// <summary>
        /// 阿里云账号pk
        /// </summary>
        [XmlElement("pk")]
        public string Pk { get; set; }
    }
}
