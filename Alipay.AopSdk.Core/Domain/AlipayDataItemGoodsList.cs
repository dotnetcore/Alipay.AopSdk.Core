using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayDataItemGoodsList Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayDataItemGoodsList : AopObject
	{
		/// <summary>
		///     单品的描述信息
		/// </summary>
		[JsonProperty("desc")]
		public string Desc { get; set; }

		/// <summary>
		///     单品id列表
		/// </summary>
		[JsonProperty("goods_list")]
		
		public List<string> GoodsList { get; set; }
	}
}