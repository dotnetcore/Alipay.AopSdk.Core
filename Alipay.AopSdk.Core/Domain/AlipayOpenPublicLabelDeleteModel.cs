using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicLabelDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicLabelDeleteModel : AopObject
	{
		/// <summary>
		///     标签id
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }
	}
}