using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayUserInviteAwardReceiveModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayUserInviteAwardReceiveModel : AopObject
	{
		/// <summary>
		///     用户扫码抽奖输入的手机号
		/// </summary>
		[JsonProperty("mobile")]
		public string Mobile { get; set; }

		/// <summary>
		///     外部业务方代码
		/// </summary>
		[JsonProperty("out_biz_code")]
		public string OutBizCode { get; set; }

		/// <summary>
		///     外部业务号
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }
	}
}