using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayInsScenePolicySurrenderApplyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayInsScenePolicySurrenderApplyModel : AopObject
	{
		/// <summary>
		///     退保扩展参数 ;标准json格式
		/// </summary>
		[JsonProperty("biz_data")]
		public string BizData { get; set; }

		/// <summary>
		///     蚂蚁保险平台生成的保单号
		/// </summary>
		[JsonProperty("policy_no")]
		public string PolicyNo { get; set; }
	}
}