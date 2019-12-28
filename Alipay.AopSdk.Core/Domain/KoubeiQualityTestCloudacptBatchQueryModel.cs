using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiQualityTestCloudacptBatchQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiQualityTestCloudacptBatchQueryModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("activity_id")]
		public string ActivityId { get; set; }

		/// <summary>
		///     partener id
		/// </summary>
		[JsonProperty("pid")]
		public string Pid { get; set; }

		/// <summary>
		///     user id
		/// </summary>
		[JsonProperty("uid")]
		public string Uid { get; set; }
	}
}