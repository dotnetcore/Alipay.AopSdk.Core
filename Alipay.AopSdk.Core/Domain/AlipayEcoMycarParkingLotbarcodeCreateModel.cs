using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarParkingLotbarcodeCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarParkingLotbarcodeCreateModel : AopObject
	{
		/// <summary>
		///     停车场编号
		/// </summary>
		[JsonProperty("parking_id")]
		public string ParkingId { get; set; }
	}
}