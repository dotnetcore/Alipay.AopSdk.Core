using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayUserAccountUseridBatchqueryResponse.
	/// </summary>
	public class AlipayUserAccountUseridBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     用户列表
		/// </summary>
		[JsonProperty("user_id_list")]
		
		public List<string> UserIdList { get; set; }
	}
}