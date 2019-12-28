using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppProdmodeDropdataQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppProdmodeDropdataQueryModel : AopObject
	{
		/// <summary>
		///     参数为：缴费业务类型
		/// </summary>
		[JsonProperty("biz_type")]
		public string BizType { get; set; }

		/// <summary>
		///     参数包含：业务类型、子业务类型、产品模式等
		/// </summary>
		[JsonProperty("search_type")]
		public string SearchType { get; set; }
	}
}