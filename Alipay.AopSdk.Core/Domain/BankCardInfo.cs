using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     BankCardInfo Data Structure.
	/// </summary>
	[Serializable]
	public class BankCardInfo : AopObject
	{
		/// <summary>
		///     银行卡持卡人姓名
		/// </summary>
		[JsonProperty("card_name")]
		public string CardName { get; set; }

		/// <summary>
		///     银行卡号
		/// </summary>
		[JsonProperty("card_no")]
		public string CardNo { get; set; }
	}
}