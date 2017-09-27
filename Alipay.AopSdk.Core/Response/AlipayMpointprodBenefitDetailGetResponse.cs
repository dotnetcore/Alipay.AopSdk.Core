using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMpointprodBenefitDetailGetResponse.
	/// </summary>
	public class AlipayMpointprodBenefitDetailGetResponse : AopResponse
	{
		/// <summary>
		///     权益详情列表
		/// </summary>
		[JsonProperty("benefit_infos")]
		
		public List<BenefitInfo> BenefitInfos { get; set; }

		/// <summary>
		///     响应码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     响应描述
		/// </summary>
		[JsonProperty("msg")]
		public string Msg { get; set; }
	}
}