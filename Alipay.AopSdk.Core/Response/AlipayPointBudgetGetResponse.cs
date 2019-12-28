using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayPointBudgetGetResponse.
	/// </summary>
	public class AlipayPointBudgetGetResponse : AopResponse
	{
		/// <summary>
		///     还可以发放的集分宝个数
		/// </summary>
		[JsonProperty("budget_amount")]
		public long BudgetAmount { get; set; }
	}
}