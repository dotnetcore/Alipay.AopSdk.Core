using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayPlatformUseridGetResponse.
	/// </summary>
	public class AlipayPlatformUseridGetResponse : AopResponse
	{
		/// <summary>
		///     id字典，key为openId，value为userId
		/// </summary>
		[JsonProperty("dict")]
		public string Dict { get; set; }
	}
}