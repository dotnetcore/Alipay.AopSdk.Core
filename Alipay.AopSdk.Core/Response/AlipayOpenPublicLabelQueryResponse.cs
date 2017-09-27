using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicLabelQueryResponse.
	/// </summary>
	public class AlipayOpenPublicLabelQueryResponse : AopResponse
	{
		/// <summary>
		///     该服务窗拥有的标签列表
		/// </summary>
		[JsonProperty("label_list")]
		
		public List<PublicLabel> LabelList { get; set; }
	}
}