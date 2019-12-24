using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozIdentificationUserWebQueryResponse.
    /// </summary>
    public class ZolozIdentificationUserWebQueryResponse : AopResponse
    {
        /// <summary>
        /// 扩展结果
        /// </summary>
        [XmlElement("extern_info")]
        public string ExternInfo { get; set; }
    }
}
