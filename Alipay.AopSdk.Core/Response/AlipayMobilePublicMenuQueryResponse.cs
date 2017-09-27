using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicMenuQueryResponse.
	/// </summary>
	public class AlipayMobilePublicMenuQueryResponse : AopResponse
	{
		/// <summary>
		///     所有菜单列表json串
		/// </summary>
		[JsonProperty("all_menu_list")]
		public string AllMenuList { get; set; }

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