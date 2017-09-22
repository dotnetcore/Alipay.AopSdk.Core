using System.Collections.Generic;
using System.Xml.Serialization;
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
		[XmlArray("citys")]
		[XmlArrayItem("city_function")]
		public List<CityFunction> Citys { get; set; }
	}
}