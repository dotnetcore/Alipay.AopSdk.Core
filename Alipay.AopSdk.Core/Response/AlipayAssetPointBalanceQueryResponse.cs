using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayAssetPointBalanceQueryResponse.
	/// </summary>
	public class AlipayAssetPointBalanceQueryResponse : AopResponse
	{
		/// <summary>
		///     用户的集分宝余额
		/// </summary>
		[JsonProperty("point_amount")]
		public long PointAmount { get; set; }
	}
}