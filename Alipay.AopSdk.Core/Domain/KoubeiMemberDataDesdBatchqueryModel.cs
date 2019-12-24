using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMemberDataDesdBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMemberDataDesdBatchqueryModel : AopObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("desd")]
        public GavintestNewLeveaOne Desd { get; set; }
    }
}
