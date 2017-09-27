using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiQualityTestCloudacptItemQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiQualityTestCloudacptItemQueryModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("activity_id")]
		public string ActivityId { get; set; }

		/// <summary>
		///     批次id
		/// </summary>
		[JsonProperty("batch_id")]
		public string BatchId { get; set; }

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