using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarDataserviceMaintainvehicleShareModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarDataserviceMaintainvehicleShareModel : AopObject
	{
		/// <summary>
		///     车辆ID
		/// </summary>
		[JsonProperty("vid")]
		public string Vid { get; set; }
	}
}