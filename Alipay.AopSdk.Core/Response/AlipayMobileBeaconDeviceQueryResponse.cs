using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobileBeaconDeviceQueryResponse.
	/// </summary>
	public class AlipayMobileBeaconDeviceQueryResponse : AopResponse
	{
		/// <summary>
		///     蓝牙设备信息
		/// </summary>
		[JsonProperty("beacon_device_info")]
		public BeaconDeviceInfo BeaconDeviceInfo { get; set; }

		/// <summary>
		///     操作返回码，200为成功
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     请求处理结果
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}