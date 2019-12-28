using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityProdSignatureTaskApplyResponse.
	/// </summary>
	public class AlipaySecurityProdSignatureTaskApplyResponse : AopResponse
	{
		/// <summary>
		///     签约订单id，关联了若干个签约任务id。
		/// </summary>
		[JsonProperty("order_id")]
		public string OrderId { get; set; }

		/// <summary>
		///     签约认证任务列表
		/// </summary>
		[JsonProperty("task_list")]
		
		public List<SignTaskResult> TaskList { get; set; }
	}
}