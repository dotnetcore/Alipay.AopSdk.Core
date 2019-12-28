using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoCplifeNoticePublishResponse.
	/// </summary>
	public class AlipayEcoCplifeNoticePublishResponse : AopResponse
	{
		/// <summary>
		///     支付宝平台统一生产的通知公告唯一ID标示.
		/// </summary>
		[JsonProperty("notice_id")]
		public string NoticeId { get; set; }
	}
}