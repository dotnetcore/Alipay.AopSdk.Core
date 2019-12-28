using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySecurityRiskCustomerriskSendModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySecurityRiskCustomerriskSendModel : AopObject
	{
		/// <summary>
		///     身份证号码
		/// </summary>
		[JsonProperty("cert_no")]
		public string CertNo { get; set; }

		/// <summary>
		///     手机号
		/// </summary>
		[JsonProperty("mobile")]
		public string Mobile { get; set; }
	}
}