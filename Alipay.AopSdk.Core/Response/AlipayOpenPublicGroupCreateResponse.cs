using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicGroupCreateResponse.
	/// </summary>
	public class AlipayOpenPublicGroupCreateResponse : AopResponse
	{
		/// <summary>
		///     分组id
		/// </summary>
		[JsonProperty("group_id")]
		public string GroupId { get; set; }
	}
}