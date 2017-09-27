using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     IdentityParams Data Structure.
	/// </summary>
	[Serializable]
	public class IdentityParams : AopObject
	{
		/// <summary>
		///     用户身份证号
		/// </summary>
		[JsonProperty("cert_no")]
		public string CertNo { get; set; }

		/// <summary>
		///     用户姓名
		/// </summary>
		[JsonProperty("user_name")]
		public string UserName { get; set; }
	}
}