using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicStdMockListsmlistApiResponse.
	/// </summary>
	public class AlipayMobilePublicStdMockListsmlistApiResponse : AopResponse
	{
		/// <summary>
		///     简单对象嵌套List
		/// </summary>
		[JsonProperty("list_sm_model_list")]
		
		public List<ListListSmMockModel> ListSmModelList { get; set; }
	}
}