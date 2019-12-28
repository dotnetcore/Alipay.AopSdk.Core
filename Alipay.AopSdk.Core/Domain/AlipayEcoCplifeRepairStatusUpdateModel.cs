using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoCplifeRepairStatusUpdateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoCplifeRepairStatusUpdateModel : AopObject
	{
		/// <summary>
		///     报修单状态明细
		/// </summary>
		[JsonProperty("biz_details")]
		public string BizDetails { get; set; }

		/// <summary>
		///     当前报修单状态
		/// </summary>
		[JsonProperty("biz_state")]
		public string BizState { get; set; }

		/// <summary>
		///     报修单ID
		/// </summary>
		[JsonProperty("req_id")]
		public string ReqId { get; set; }
	}
}