using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SsdataDataserviceRiskIpprofileQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class SsdataDataserviceRiskIpprofileQueryModel : AopObject
	{
		/// <summary>
		///     IP地址
		/// </summary>
		[JsonProperty("ip_address")]
		public string IpAddress { get; set; }

		/// <summary>
		///     手机号码
		/// </summary>
		[JsonProperty("phone")]
		public string Phone { get; set; }
	}
}