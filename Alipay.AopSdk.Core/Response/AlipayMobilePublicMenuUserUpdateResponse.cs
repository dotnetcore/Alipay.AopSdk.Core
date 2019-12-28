using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicMenuUserUpdateResponse.
	/// </summary>
	public class AlipayMobilePublicMenuUserUpdateResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     结果描述
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}