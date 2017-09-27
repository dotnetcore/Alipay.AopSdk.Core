using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppProdmodeUnionbankQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppProdmodeUnionbankQueryModel : AopObject
	{
		/// <summary>
		///     银联编号
		/// </summary>
		[JsonProperty("bank_code")]
		public string BankCode { get; set; }
	}
}