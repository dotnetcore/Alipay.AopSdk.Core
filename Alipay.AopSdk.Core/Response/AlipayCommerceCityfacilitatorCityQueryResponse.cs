using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorCityQueryResponse.
	/// </summary>
	public class AlipayCommerceCityfacilitatorCityQueryResponse : AopResponse
	{
		/// <summary>
		///     城市列表
		/// </summary>
		[JsonProperty("citys")]
		
		public List<CityFunction> Citys { get; set; }
	}
}