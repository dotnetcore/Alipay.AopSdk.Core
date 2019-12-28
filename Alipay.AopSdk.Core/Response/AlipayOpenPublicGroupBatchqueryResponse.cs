using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicGroupBatchqueryResponse.
	/// </summary>
	public class AlipayOpenPublicGroupBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     用户分组列表，包含每个分组的id、name、以及规则模型
		/// </summary>
		[JsonProperty("groups")]
		
		public List<QueryGroup> Groups { get; set; }
	}
}