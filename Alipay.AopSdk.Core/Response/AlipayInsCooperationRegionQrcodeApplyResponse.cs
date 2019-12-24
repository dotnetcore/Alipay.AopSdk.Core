using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayInsCooperationRegionQrcodeApplyResponse.
    /// </summary>
    public class AlipayInsCooperationRegionQrcodeApplyResponse : AopResponse
    {
        /// <summary>
        /// 快捷投保产品二维码图片链接URL
        /// </summary>
        [XmlElement("code_url")]
        public string CodeUrl { get; set; }
    }
}
