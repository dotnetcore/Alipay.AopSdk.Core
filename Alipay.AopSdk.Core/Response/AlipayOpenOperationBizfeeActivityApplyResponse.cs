using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenOperationBizfeeActivityApplyResponse.
    /// </summary>
    public class AlipayOpenOperationBizfeeActivityApplyResponse : AopResponse
    {
        /// <summary>
        /// 返回结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回结果描述信息
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }
    }
}
