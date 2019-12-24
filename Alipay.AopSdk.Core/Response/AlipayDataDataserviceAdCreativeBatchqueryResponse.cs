using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 创意按条件分页查询结果
        /// </summary>
        [XmlElement("creative_list")]
        public PageCreative CreativeList { get; set; }
    }
}
