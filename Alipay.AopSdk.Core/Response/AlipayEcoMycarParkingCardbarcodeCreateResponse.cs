using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoMycarParkingCardbarcodeCreateResponse.
	/// </summary>
	public class AlipayEcoMycarParkingCardbarcodeCreateResponse : AopResponse
	{
		/// <summary>
		///     停车车卡对应二维码列表
		/// </summary>
		[JsonProperty("qrcodes")]
		
		public List<QRcode> Qrcodes { get; set; }
	}
}