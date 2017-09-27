using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataCustomreportDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataCustomreportDeleteModel : AopObject
	{
		/// <summary>
		///     自定义报表规则的KEY
		/// </summary>
		[JsonProperty("condition_key")]
		public string ConditionKey { get; set; }
	}
}