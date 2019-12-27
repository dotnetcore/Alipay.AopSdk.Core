using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionOnlineResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountSolutionOnlineResponse : AopResponse
    {
        /// <summary>
        /// 贴息方案实例id
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 贴息方案是否生效，true生效，false没有生效
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
