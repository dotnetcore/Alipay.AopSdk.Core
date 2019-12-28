using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicLabelModifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicLabelModifyModel : AopObject
	{
		/// <summary>
		///     要修改的标签id
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     要修改成的标签名
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}