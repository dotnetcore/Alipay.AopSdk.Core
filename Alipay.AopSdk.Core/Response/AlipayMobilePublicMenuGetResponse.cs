using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicMenuGetResponse.
	/// </summary>
	public class AlipayMobilePublicMenuGetResponse : AopResponse
	{
		/// <summary>
		///     success
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     菜单内容
		/// </summary>
		[JsonProperty("menu_content")]
		public string MenuContent { get; set; }

		/// <summary>
		///     成功
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}