using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMemberDataDesdBatchqueryResponse.
    /// </summary>
    public class KoubeiMemberDataDesdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("de")]
        public GavintestNewonline De { get; set; }
    }
}
