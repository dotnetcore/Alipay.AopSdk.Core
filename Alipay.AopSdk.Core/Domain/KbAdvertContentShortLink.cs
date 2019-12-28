using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbAdvertContentShortLink Data Structure.
	/// </summary>
	[Serializable]
	public class KbAdvertContentShortLink : AopObject
	{
		/// <summary>
		///     链接地址
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}