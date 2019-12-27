using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicLifeLabelBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("labels")]
        [XmlArrayItem("life_label")]
        public List<LifeLabel> Labels { get; set; }
    }
}
