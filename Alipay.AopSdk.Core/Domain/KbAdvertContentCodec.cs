using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertContentCodec Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertContentCodec : AopObject
	{
		/// <summary>
		///     二维码广告内容
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}