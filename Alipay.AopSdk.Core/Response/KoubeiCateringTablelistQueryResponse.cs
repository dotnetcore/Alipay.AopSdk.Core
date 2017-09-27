using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiCateringTablelistQueryResponse.
	/// </summary>
	public class KoubeiCateringTablelistQueryResponse : AopResponse
	{
		/// <summary>
		///     返回tablelistresult列表
		/// </summary>
		[JsonProperty("tableinfo_result")]
		public TableInfoResult TableinfoResult { get; set; }
	}
}