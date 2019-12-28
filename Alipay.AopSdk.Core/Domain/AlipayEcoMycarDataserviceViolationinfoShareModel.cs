using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarDataserviceViolationinfoShareModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarDataserviceViolationinfoShareModel : AopObject
	{
		/// <summary>
		///     支付宝app_id
		/// </summary>
		[JsonProperty("app_id")]
		public string AppId { get; set; }

		/// <summary>
		///     车辆id
		/// </summary>
		[JsonProperty("vehicle_id")]
		public string VehicleId { get; set; }
	}
}