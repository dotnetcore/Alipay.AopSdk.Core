using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobileBeaconDeviceDeleteResponse.
	/// </summary>
	public class AlipayMobileBeaconDeviceDeleteResponse : AopResponse
	{
		/// <summary>
		///     操作返回码
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