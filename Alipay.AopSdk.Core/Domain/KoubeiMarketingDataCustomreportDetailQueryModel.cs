using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingDataCustomreportDetailQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingDataCustomreportDetailQueryModel : AopObject
	{
		/// <summary>
		///     自定义报表的规则KEY
		/// </summary>
		[JsonProperty("condition_key")]
		public string ConditionKey { get; set; }
	}
}