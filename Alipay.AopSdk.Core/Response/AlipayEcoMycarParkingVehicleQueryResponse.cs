using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoMycarParkingVehicleQueryResponse.
	/// </summary>
	public class AlipayEcoMycarParkingVehicleQueryResponse : AopResponse
	{
		/// <summary>
		///     车牌信息（utf-8编码）
		/// </summary>
		[JsonProperty("car_number")]
		public string CarNumber { get; set; }
	}
}