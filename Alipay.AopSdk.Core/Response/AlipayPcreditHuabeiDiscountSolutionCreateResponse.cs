using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionCreateResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountSolutionCreateResponse : AopResponse
    {
        /// <summary>
        /// solution_id，创建成功后返回的贴息活动方案id
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }
    }
}
