using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenAuthIndustryPlatformCreateTokenResponse.
	/// </summary>
	public class AlipayOpenAuthIndustryPlatformCreateTokenResponse : AopResponse
	{
		/// <summary>
		///     授权码
		/// </summary>
		[JsonProperty("auth_code")]
		public string AuthCode { get; set; }

		/// <summary>
		///     appid
		/// </summary>
		[JsonProperty("requst_app_id")]
		public string RequstAppId { get; set; }

		/// <summary>
		///     scope
		/// </summary>
		[JsonProperty("scope")]
		public string Scope { get; set; }
	}
}