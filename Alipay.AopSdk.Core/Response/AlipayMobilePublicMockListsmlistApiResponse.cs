using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicMockListsmlistApiResponse.
	/// </summary>
	public class AlipayMobilePublicMockListsmlistApiResponse : AopResponse
	{
		/// <summary>
		///     简单模型嵌套list
		/// </summary>
		[JsonProperty("list_sm_model_list")]
		
		public List<ListListSmMockModel> ListSmModelList { get; set; }
	}
}