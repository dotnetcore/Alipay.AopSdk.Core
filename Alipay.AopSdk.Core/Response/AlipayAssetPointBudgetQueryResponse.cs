using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayAssetPointBudgetQueryResponse.
	/// </summary>
	public class AlipayAssetPointBudgetQueryResponse : AopResponse
	{
		/// <summary>
		///     还可以发放的集分宝个数
		/// </summary>
		[JsonProperty("budget_amount")]
		public long BudgetAmount { get; set; }
	}
}