using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarDialogonlineVehicleQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarDialogonlineVehicleQueryModel : AopObject
	{
		/// <summary>
		///     车辆ID
		/// </summary>
		[JsonProperty("vi_id")]
		public string ViId { get; set; }
	}
}