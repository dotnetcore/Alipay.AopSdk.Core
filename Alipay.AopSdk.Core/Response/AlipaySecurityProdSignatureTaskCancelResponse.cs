using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityProdSignatureTaskCancelResponse.
	/// </summary>
	public class AlipaySecurityProdSignatureTaskCancelResponse : AopResponse
	{
		/// <summary>
		///     是否更新成功
		/// </summary>
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}