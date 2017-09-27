using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     NewsfeedWithMeInfo Data Structure.
	/// </summary>
	[Serializable]
	public class NewsfeedWithMeInfo : AopObject
	{
		/// <summary>
		///     登录ID
		/// </summary>
		[JsonProperty("login_id")]
		public string LoginId { get; set; }

		/// <summary>
		///     用户id
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}