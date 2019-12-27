using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipaySecurityProdSignatureFileUploadResponse.
    /// </summary>
    public class AlipaySecurityProdSignatureFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件唯一标识，用于apply接口传入
        /// </summary>
        [XmlElement("oss_file_id")]
        public string OssFileId { get; set; }
    }
}
