using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobileStdPublicAccountQueryResponse.
	/// </summary>
	public class AlipayMobileStdPublicAccountQueryResponse : AopResponse
	{
		/// <summary>
		///     绑定账户列表
		/// </summary>
		[JsonProperty("public_bind_accounts")]
		
		public List<PublicBindAccount> PublicBindAccounts { get; set; }
	}
}