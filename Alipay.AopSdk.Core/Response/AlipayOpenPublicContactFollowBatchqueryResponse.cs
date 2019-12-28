using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicContactFollowBatchqueryResponse.
	/// </summary>
	public class AlipayOpenPublicContactFollowBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     联系人关注者列表
		/// </summary>
		[JsonProperty("contact_follow_list")]
		
		public List<ContactFollower> ContactFollowList { get; set; }
	}
}