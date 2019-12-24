using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppUpdattestBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppUpdattestBatchqueryModel : AopObject
    {
        /// <summary>
        /// 64
        /// </summary>
        [XmlElement("campus_card")]
        public string CampusCard { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("s")]
        public string S { get; set; }
    }
}
