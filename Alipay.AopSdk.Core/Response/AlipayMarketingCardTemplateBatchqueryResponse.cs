using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingCardTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCardTemplateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 会员卡模板基本信息
        /// </summary>
        [XmlArray("mcard_template")]
        [XmlArrayItem("mcard_template")]
        public List<McardTemplate> McardTemplate { get; set; }

        /// <summary>
        /// 会员卡模板总数
        /// </summary>
        [XmlElement("template_total")]
        public long TemplateTotal { get; set; }
    }
}
