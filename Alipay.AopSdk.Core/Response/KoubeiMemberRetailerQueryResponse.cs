using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMemberRetailerQueryResponse.
	/// </summary>
	public class KoubeiMemberRetailerQueryResponse : AopResponse
	{
		/// <summary>
		///     零售商信息列表
		/// </summary>
		[JsonProperty("retailer_list")]
		
		public List<Retailer> RetailerList { get; set; }
	}
}