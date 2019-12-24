using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockBizQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockBizQueryResponse : AopResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
