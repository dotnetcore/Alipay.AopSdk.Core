using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoEprintCodeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintCodeNotifyModel : AopObject
    {
        /// <summary>
        /// 授权code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 授权门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
