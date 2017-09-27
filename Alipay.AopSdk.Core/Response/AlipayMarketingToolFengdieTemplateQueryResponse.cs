using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingToolFengdieTemplateQueryResponse.
	/// </summary>
	public class AlipayMarketingToolFengdieTemplateQueryResponse : AopResponse
	{
		/// <summary>
		///     开发者开发上传的H5模板列表
		/// </summary>
		[JsonProperty("template")]
		
		public List<FengdieTemplate> Template { get; set; }
	}
}