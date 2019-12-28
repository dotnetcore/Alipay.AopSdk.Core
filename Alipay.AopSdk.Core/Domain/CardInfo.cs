using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CardInfo Data Structure.
	/// </summary>
	[Serializable]
	public class CardInfo : AopObject
	{
		/// <summary>
		///     领取时间
		/// </summary>
		[JsonProperty("taken_time")]
		public string TakenTime { get; set; }

		/// <summary>
		///     用户名
		/// </summary>
		[JsonProperty("user_name")]
		public string UserName { get; set; }
	}
}