using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySystemOauthTokenResponse.
	/// </summary>
	public class AlipaySystemOauthTokenResponse : AopResponse
	{
		/// <summary>
		///     访问令牌。通过该令牌调用需要授权类接口
		/// </summary>
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		/// <summary>
		///     已废弃，请勿使用
		/// </summary>
		[JsonProperty("alipay_user_id")]
		public string AlipayUserId { get; set; }

		/// <summary>
		///     访问令牌的有效时间，单位是秒。
		/// </summary>
		[JsonProperty("expires_in")]
		public string ExpiresIn { get; set; }

		/// <summary>
		///     刷新令牌的有效时间，单位是秒。
		/// </summary>
		[JsonProperty("re_expires_in")]
		public string ReExpiresIn { get; set; }

		/// <summary>
		///     刷新令牌。通过该令牌可以刷新access_token
		/// </summary>
		[JsonProperty("refresh_token")]
		public string RefreshToken { get; set; }

		/// <summary>
		///     支付宝用户的唯一userId
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}