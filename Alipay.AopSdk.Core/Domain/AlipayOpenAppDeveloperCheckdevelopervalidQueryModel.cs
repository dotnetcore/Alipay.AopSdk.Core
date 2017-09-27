using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenAppDeveloperCheckdevelopervalidQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenAppDeveloperCheckdevelopervalidQueryModel : AopObject
	{
		/// <summary>
		///     支付宝账号
		/// </summary>
		[JsonProperty("logon_id")]
		public string LogonId { get; set; }
	}
}