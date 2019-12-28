using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenAuthTokenAppQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenAuthTokenAppQueryModel : AopObject
	{
		/// <summary>
		///     应用授权令牌
		/// </summary>
		[JsonProperty("app_auth_token")]
		public string AppAuthToken { get; set; }
	}
}