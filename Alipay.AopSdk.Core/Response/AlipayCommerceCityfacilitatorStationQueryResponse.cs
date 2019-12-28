using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorStationQueryResponse.
	/// </summary>
	public class AlipayCommerceCityfacilitatorStationQueryResponse : AopResponse
	{
		/// <summary>
		///     支持设为起点的站点列表
		/// </summary>
		[JsonProperty("support_starts")]
		
		public List<StationDetailInfo> SupportStarts { get; set; }
	}
}