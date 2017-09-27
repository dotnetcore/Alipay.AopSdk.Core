using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     SsdataDataserviceRiskAlixiaohaoQueryResponse.
	/// </summary>
	public class SsdataDataserviceRiskAlixiaohaoQueryResponse : AopResponse
	{
		/// <summary>
		///     是否阿里小号
		/// </summary>
		[JsonProperty("is_alixiaohao")]
		public bool IsAlixiaohao { get; set; }
	}
}