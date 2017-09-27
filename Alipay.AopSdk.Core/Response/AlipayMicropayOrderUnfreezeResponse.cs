using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMicropayOrderUnfreezeResponse.
	/// </summary>
	public class AlipayMicropayOrderUnfreezeResponse : AopResponse
	{
		/// <summary>
		///     冻结订单详情结果
		/// </summary>
		[JsonProperty("unfreeze_order_detail")]
		public UnfreezeOrderDetail UnfreezeOrderDetail { get; set; }
	}
}