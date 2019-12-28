using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicLabelCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicLabelCreateModel : AopObject
	{
		/// <summary>
		///     标签名
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}