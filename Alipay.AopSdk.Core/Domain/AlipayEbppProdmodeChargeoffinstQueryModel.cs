using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppProdmodeChargeoffinstQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppProdmodeChargeoffinstQueryModel : AopObject
	{
		/// <summary>
		///     业务类型
		/// </summary>
		[JsonProperty("biz_type")]
		public string BizType { get; set; }
	}
}