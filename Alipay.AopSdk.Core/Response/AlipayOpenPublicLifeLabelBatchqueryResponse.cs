using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicLifeLabelBatchqueryResponse.
	/// </summary>
	public class AlipayOpenPublicLifeLabelBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     标签列表
		/// </summary>
		[JsonProperty("labels")]
		
		public List<LifeLabel> Labels { get; set; }
	}
}