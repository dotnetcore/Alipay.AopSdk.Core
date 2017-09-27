using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayFinanceFundFundquotationQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayFinanceFundFundquotationQueryModel : AopObject
	{
		/// <summary>
		///     基金编号：基金产品编号
		/// </summary>
		[JsonProperty("fund_code")]
		public string FundCode { get; set; }
	}
}