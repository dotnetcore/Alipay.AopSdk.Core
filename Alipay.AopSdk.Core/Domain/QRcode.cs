using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     QRcode Data Structure.
	/// </summary>
	[Serializable]
	public class QRcode : AopObject
	{
		/// <summary>
		///     用户ID
		/// </summary>
		[JsonProperty("card_id")]
		public string CardId { get; set; }

		/// <summary>
		///     qrcode地址
		/// </summary>
		[JsonProperty("qrcode_url")]
		public string QrcodeUrl { get; set; }
	}
}