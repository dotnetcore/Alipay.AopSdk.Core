using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingDataCustomreportSaveResponse.
	/// </summary>
	public class KoubeiMarketingDataCustomreportSaveResponse : AopResponse
	{
		/// <summary>
		///     自定义报表的规则ID
		/// </summary>
		[JsonProperty("condition_key")]
		public string ConditionKey { get; set; }
	}
}