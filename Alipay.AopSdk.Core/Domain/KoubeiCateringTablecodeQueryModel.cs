using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiCateringTablecodeQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiCateringTablecodeQueryModel : AopObject
	{
		/// <summary>
		///     用户在isv界面通过扫一扫传入的url文本
		/// </summary>
		[JsonProperty("url_context")]
		public string UrlContext { get; set; }
	}
}