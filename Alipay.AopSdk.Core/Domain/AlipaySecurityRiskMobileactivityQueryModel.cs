using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySecurityRiskMobileactivityQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySecurityRiskMobileactivityQueryModel : AopObject
	{
		/// <summary>
		///     账户绑定手机号
		/// </summary>
		[JsonProperty("mobile")]
		public string Mobile { get; set; }

		/// <summary>
		///     场景名称
		/// </summary>
		[JsonProperty("scene_id")]
		public string SceneId { get; set; }

		/// <summary>
		///     支付宝userId
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}