using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ContactFollower Data Structure.
	/// </summary>
	[Serializable]
	public class ContactFollower : AopObject
	{
		/// <summary>
		///     支付宝头像
		/// </summary>
		[JsonProperty("avatar")]
		public string Avatar { get; set; }

		/// <summary>
		///     默认头像
		/// </summary>
		[JsonProperty("default_avatar")]
		public string DefaultAvatar { get; set; }

		/// <summary>
		///     false
		/// </summary>
		[JsonProperty("each_record_flag")]
		public string EachRecordFlag { get; set; }

		/// <summary>
		///     用户id
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}