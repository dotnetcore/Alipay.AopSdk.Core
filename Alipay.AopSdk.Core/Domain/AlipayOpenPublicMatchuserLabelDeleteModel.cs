using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicMatchuserLabelDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicMatchuserLabelDeleteModel : AopObject
	{
		/// <summary>
		///     标签id
		/// </summary>
		[JsonProperty("label_id")]
		public string LabelId { get; set; }

		/// <summary>
		///     支付宝用户匹配器列表，最多传入10条
		/// </summary>
		[JsonProperty("matchers")]
		
		public List<Matcher> Matchers { get; set; }
	}
}