using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SkuPropertyValue Data Structure.
	/// </summary>
	[Serializable]
	public class SkuPropertyValue : AopObject
	{
		/// <summary>
		///     外部sku属性值ID,由外部商户定义
		/// </summary>
		[JsonProperty("out_pv_id")]
		public string OutPvId { get; set; }

		/// <summary>
		///     外部商户sku属性值
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}