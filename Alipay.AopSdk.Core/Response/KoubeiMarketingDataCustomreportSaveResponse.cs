using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportSaveResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportSaveResponse : AopResponse
    {
        /// <summary>
        /// 自定义报表的规则ID
        /// </summary>
        [XmlElement("condition_key")]
        public string ConditionKey { get; set; }
    }
}
