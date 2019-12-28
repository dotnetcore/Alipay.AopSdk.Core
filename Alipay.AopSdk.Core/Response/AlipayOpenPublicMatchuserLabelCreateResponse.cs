using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicMatchuserLabelCreateResponse.
	/// </summary>
	public class AlipayOpenPublicMatchuserLabelCreateResponse : AopResponse
	{
		/// <summary>
		///     用户打标失败数量
		/// </summary>
		[JsonProperty("error_count")]
		public long ErrorCount { get; set; }

		/// <summary>
		///     出错的匹配器列表
		/// </summary>
		[JsonProperty("error_matchers")]
		
		public List<ErrorMatcher> ErrorMatchers { get; set; }
	}
}