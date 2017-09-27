using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarParkingConfigQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarParkingConfigQueryModel : AopObject
	{
		/// <summary>
		///     传入参数固定值:alipay.eco.mycar.parking.userpage.query
		/// </summary>
		[JsonProperty("interface_name")]
		public string InterfaceName { get; set; }

		/// <summary>
		///     传入参数固定值:interface_page
		/// </summary>
		[JsonProperty("interface_type")]
		public string InterfaceType { get; set; }
	}
}