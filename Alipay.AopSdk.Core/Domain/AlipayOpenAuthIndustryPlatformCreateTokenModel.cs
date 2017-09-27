using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenAuthIndustryPlatformCreateTokenModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenAuthIndustryPlatformCreateTokenModel : AopObject
	{
		/// <summary>
		///     isv的appid
		/// </summary>
		[JsonProperty("isv_appid")]
		public string IsvAppid { get; set; }

		/// <summary>
		///     auth_mycar_violation
		/// </summary>
		[JsonProperty("scope")]
		public string Scope { get; set; }
	}
}