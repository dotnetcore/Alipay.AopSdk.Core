using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoEprintTokenGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintTokenGetModel : AopObject
    {
        /// <summary>
        /// 是否优先从缓存中拿取，false则强制刷新，1天20次
        /// </summary>
        [XmlElement("cache_first")]
        public bool CacheFirst { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用Secret
        /// </summary>
        [XmlElement("client_secret")]
        public string ClientSecret { get; set; }
    }
}
