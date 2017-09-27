using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicMenuAddResponse.
	/// </summary>
	public class AlipayMobilePublicMenuAddResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     成功
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}