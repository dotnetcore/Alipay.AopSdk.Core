using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppProdmodeProvcityQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppProdmodeProvcityQueryModel : AopObject
	{
		/// <summary>
		///     省市编号
		/// </summary>
		[JsonProperty("adcode")]
		public string Adcode { get; set; }

		/// <summary>
		///     查询类型，queryType=1,查询省下面的市信息
		/// </summary>
		[JsonProperty("query_type")]
		public string QueryType { get; set; }
	}
}