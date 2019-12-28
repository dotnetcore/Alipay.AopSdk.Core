using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoMycarParkingLotbarcodeCreateResponse.
	/// </summary>
	public class AlipayEcoMycarParkingLotbarcodeCreateResponse : AopResponse
	{
		/// <summary>
		///     返回二维码链接地址
		/// </summary>
		[JsonProperty("qrcode_url")]
		public string QrcodeUrl { get; set; }

		/// <summary>
		///     返回状态：1为成功，0为失败
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}