using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZhimaCreditContractBorrowInitializeResponse.
    /// </summary>
    public class ZhimaCreditContractBorrowInitializeResponse : AopResponse
    {
        /// <summary>
        /// url：mode=0(二维码主扫模式)下，返回的url，在借还的机具上渲染为二维码后，用户使用支付宝扫一扫唤起该页面
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
