using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicAccountQueryResponse.
	/// </summary>
	public class AlipayMobilePublicAccountQueryResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     菜单唯一标识
		/// </summary>
		[JsonProperty("menu_key")]
		public string MenuKey { get; set; }

		/// <summary>
		///     结果描述
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }

		/// <summary>
		///     绑定账户列表
		/// </summary>
		[JsonProperty("public_bind_accounts")]
		
		public List<PublicBindAccount> PublicBindAccounts { get; set; }

		/// <summary>
		///     备注信息
		/// </summary>
		[JsonProperty("remark")]
		public string Remark { get; set; }
	}
}