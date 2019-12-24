using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiSalesLeadsSaleleadsCreateResponse.
    /// </summary>
    public class KoubeiSalesLeadsSaleleadsCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成的销售LeadsId
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }
    }
}
