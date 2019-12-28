using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayBossCsDatacollectSendModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayBossCsDatacollectSendModel : AopObject
	{
		/// <summary>
		///     上数提交数据内容
		/// </summary>
		[JsonProperty("content")]
		public string Content { get; set; }
	}
}