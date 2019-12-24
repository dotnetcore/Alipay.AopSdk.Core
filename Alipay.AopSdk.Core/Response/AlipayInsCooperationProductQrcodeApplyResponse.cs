using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayInsCooperationProductQrcodeApplyResponse.
    /// </summary>
    public class AlipayInsCooperationProductQrcodeApplyResponse : AopResponse
    {
        /// <summary>
        /// 快捷投保产品二维码图片链接URL
        /// </summary>
        [XmlElement("code_url")]
        public string CodeUrl { get; set; }
    }
}
