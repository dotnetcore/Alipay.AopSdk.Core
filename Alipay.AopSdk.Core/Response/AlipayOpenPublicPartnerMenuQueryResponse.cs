using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicPartnerMenuQueryResponse.
	/// </summary>
	public class AlipayOpenPublicPartnerMenuQueryResponse : AopResponse
	{
		/// <summary>
		///     服务窗菜单
		/// </summary>
		[JsonProperty("public_menu")]
		public string PublicMenu { get; set; }
	}
}