using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicLifeAgentcreateQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicLifeAgentcreateQueryModel : AopObject
	{
		/// <summary>
		///     由开发者创建的外部入驻申请单据号
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }
	}
}