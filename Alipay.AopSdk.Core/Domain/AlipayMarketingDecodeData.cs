using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingDecodeData Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingDecodeData : AopObject
	{
		/// <summary>
		///     钱包二维码码值
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }
	}
}