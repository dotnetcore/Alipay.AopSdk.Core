using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 模板详情列表
        /// </summary>
        [XmlElement("data")]
        public FengdieTemplateListRespModel Data { get; set; }
    }
}
