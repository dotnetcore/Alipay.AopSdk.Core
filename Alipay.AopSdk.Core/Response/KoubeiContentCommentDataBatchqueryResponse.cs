using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiContentCommentDataBatchqueryResponse.
	/// </summary>
	public class KoubeiContentCommentDataBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     评价结果列表
		/// </summary>
		[JsonProperty("comments")]
		
		public List<CommentOpenModel> Comments { get; set; }

		/// <summary>
		///     当前查询条件下评价总数
		/// </summary>
		[JsonProperty("count")]
		public long Count { get; set; }
	}
}