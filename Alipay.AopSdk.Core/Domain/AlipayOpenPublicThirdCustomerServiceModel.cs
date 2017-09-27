using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicThirdCustomerServiceModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicThirdCustomerServiceModel : AopObject
	{
		/// <summary>
		///     服务窗商户在渠道商处对应的用户id
		/// </summary>
		[JsonProperty("channel_uid")]
		public string ChannelUid { get; set; }
	}
}