using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayEcapiprodDataPutResponse.
    /// </summary>
    public class AlipayEcapiprodDataPutResponse : AopResponse
    {
        /// <summary>
        /// 数据版本
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }
    }
}
