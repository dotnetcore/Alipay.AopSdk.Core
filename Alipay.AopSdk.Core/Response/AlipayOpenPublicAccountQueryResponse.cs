using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicAccountQueryResponse.
	/// </summary>
	public class AlipayOpenPublicAccountQueryResponse : AopResponse
	{
		/// <summary>
		///     绑定账户列表
		/// </summary>
		[JsonProperty("public_bind_accounts")]
		
		public List<StdPublicBindAccount> PublicBindAccounts { get; set; }
	}
}