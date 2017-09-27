using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicPersonalizedMenuCreateResponse.
	/// </summary>
	public class AlipayOpenPublicPersonalizedMenuCreateResponse : AopResponse
	{
		/// <summary>
		///     该套个性化菜单key
		/// </summary>
		[JsonProperty("menu_key")]
		public string MenuKey { get; set; }
	}
}