using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicContactFollowListResponse.
	/// </summary>
	public class AlipayMobilePublicContactFollowListResponse : AopResponse
	{
		/// <summary>
		///     返回结果码，如200，标识成功
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     联系人关注者列表
		/// </summary>
		[JsonProperty("contact_follow_list")]
		
		public List<string> ContactFollowList { get; set; }
	}
}