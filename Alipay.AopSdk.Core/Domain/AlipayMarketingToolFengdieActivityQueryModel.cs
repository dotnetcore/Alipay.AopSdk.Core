using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingToolFengdieActivityQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingToolFengdieActivityQueryModel : AopObject
	{
		/// <summary>
		///     H5应用的唯一id，调用alipay.marketing.tool.fengdie.activity.create获得
		/// </summary>
		[JsonProperty("activity_id")]
		public long ActivityId { get; set; }
	}
}