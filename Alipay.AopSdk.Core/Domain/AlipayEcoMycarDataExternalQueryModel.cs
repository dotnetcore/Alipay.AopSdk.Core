using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarDataExternalQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarDataExternalQueryModel : AopObject
	{
		/// <summary>
		///     external_system_name
		/// </summary>
		[JsonProperty("external_system_name")]
		public string ExternalSystemName { get; set; }

		/// <summary>
		///     is_transfer_uid
		/// </summary>
		[JsonProperty("is_transfer_uid")]
		public bool IsTransferUid { get; set; }

		/// <summary>
		///     operate_type
		/// </summary>
		[JsonProperty("operate_type")]
		public string OperateType { get; set; }

		/// <summary>
		///     query_condition
		/// </summary>
		[JsonProperty("query_condition")]
		public string QueryCondition { get; set; }
	}
}