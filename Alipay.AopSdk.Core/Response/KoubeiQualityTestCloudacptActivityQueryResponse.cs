using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiQualityTestCloudacptActivityQueryResponse.
	/// </summary>
	public class KoubeiQualityTestCloudacptActivityQueryResponse : AopResponse
	{
		/// <summary>
		///     活动列表
		/// </summary>
		[JsonProperty("activity_list")]
		
		public List<OpenActivity> ActivityList { get; set; }
	}
}