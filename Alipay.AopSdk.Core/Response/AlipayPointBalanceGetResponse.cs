using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayPointBalanceGetResponse.
	/// </summary>
	public class AlipayPointBalanceGetResponse : AopResponse
	{
		/// <summary>
		///     用户的集分宝余额
		/// </summary>
		[JsonProperty("point_amount")]
		public long PointAmount { get; set; }
	}
}