using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicPersonalizedExtensionBatchqueryResponse.
	/// </summary>
	public class AlipayOpenPublicPersonalizedExtensionBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     扩展区套数
		/// </summary>
		[JsonProperty("count")]
		public long Count { get; set; }

		/// <summary>
		///     扩展区信息
		/// </summary>
		[JsonProperty("extensions")]
		
		public List<QueryExtension> Extensions { get; set; }
	}
}