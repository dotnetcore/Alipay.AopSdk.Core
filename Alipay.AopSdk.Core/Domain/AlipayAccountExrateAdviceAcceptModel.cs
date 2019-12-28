using System;
using Newtonsoft.Json;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayAccountExrateAdviceAcceptModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayAccountExrateAdviceAcceptModel : AopObject
	{
		/// <summary>
		///     交易请求对象内容
		/// </summary>
		[JsonProperty("advice")]
		public AdviceVO Advice { get; set; }
	}
}