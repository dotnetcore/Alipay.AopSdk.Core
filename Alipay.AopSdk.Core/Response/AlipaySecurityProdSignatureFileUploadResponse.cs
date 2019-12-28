using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityProdSignatureFileUploadResponse.
	/// </summary>
	public class AlipaySecurityProdSignatureFileUploadResponse : AopResponse
	{
		/// <summary>
		///     文件唯一标识，用于apply接口传入
		/// </summary>
		[JsonProperty("oss_file_id")]
		public string OssFileId { get; set; }
	}
}