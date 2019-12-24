using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionOfflineResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountSolutionOfflineResponse : AopResponse
    {
        /// <summary>
        /// 贴息方案是否下架成功，true下架成功，false下架失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
