using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     QueryProvCityInfo Data Structure.
	/// </summary>
	[Serializable]
	public class QueryProvCityInfo : AopObject
	{
		/// <summary>
		///     省市编号
		/// </summary>
		[JsonProperty("adcode")]
		public string Adcode { get; set; }

		/// <summary>
		///     城市名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}