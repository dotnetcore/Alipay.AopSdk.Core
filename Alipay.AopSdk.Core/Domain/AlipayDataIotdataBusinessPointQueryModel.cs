using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataBusinessPointQueryModel : AopObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("business_id")]
        public long BusinessId { get; set; }
    }
}
