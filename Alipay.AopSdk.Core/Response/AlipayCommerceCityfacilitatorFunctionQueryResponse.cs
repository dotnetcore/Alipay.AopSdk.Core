using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorFunctionQueryResponse.
	/// </summary>
	public class AlipayCommerceCityfacilitatorFunctionQueryResponse : AopResponse
	{
		/// <summary>
		///     支持的功能列表
		/// </summary>
		[JsonProperty("functions")]
		
		public List<SupportFunction> Functions { get; set; }
	}
}