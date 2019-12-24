using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayEcardEduPublicBindResponse.
    /// </summary>
    public class AlipayEcardEduPublicBindResponse : AopResponse
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }
    }
}
