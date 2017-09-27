using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicLabelQueryResponse.
	/// </summary>
	public class AlipayMobilePublicLabelQueryResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     所有标签
		/// </summary>
		[JsonProperty("labels")]
		
		public List<string> Labels { get; set; }

		/// <summary>
		///     结果信息
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}