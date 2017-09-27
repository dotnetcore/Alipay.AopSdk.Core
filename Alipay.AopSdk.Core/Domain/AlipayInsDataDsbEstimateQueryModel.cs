using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayInsDataDsbEstimateQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayInsDataDsbEstimateQueryModel : AopObject
	{
		/// <summary>
		///     定损单号
		/// </summary>
		[JsonProperty("estimate_no")]
		public string EstimateNo { get; set; }

		/// <summary>
		///     车架号
		/// </summary>
		[JsonProperty("frame_no")]
		public string FrameNo { get; set; }

		/// <summary>
		///     车牌号
		/// </summary>
		[JsonProperty("license_no")]
		public string LicenseNo { get; set; }
	}
}