using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarViolationVehicleQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarViolationVehicleQueryModel : AopObject
	{
		/// <summary>
		///     用户车辆ID,支付宝系统唯一
		/// </summary>
		[JsonProperty("vi_id")]
		public string ViId { get; set; }
	}
}