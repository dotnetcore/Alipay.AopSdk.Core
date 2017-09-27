using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicLifeModifyResponse.
	/// </summary>
	public class AlipayOpenPublicLifeModifyResponse : AopResponse
	{
		/// <summary>
		///     修改时间。
		/// </summary>
		[JsonProperty("modify_time")]
		public string ModifyTime { get; set; }

		/// <summary>
		///     生活号id，用于表示此生活号唯一性
		/// </summary>
		[JsonProperty("public_id")]
		public string PublicId { get; set; }
	}
}