using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobileStdPublicExpressUserQueryResponse.
	/// </summary>
	public class AlipayMobileStdPublicExpressUserQueryResponse : AopResponse
	{
		/// <summary>
		///     证件号
		/// </summary>
		[JsonProperty("cert_no")]
		public string CertNo { get; set; }

		/// <summary>
		///     证件类型，身份证
		/// </summary>
		[JsonProperty("cert_type")]
		public string CertType { get; set; }
	}
}