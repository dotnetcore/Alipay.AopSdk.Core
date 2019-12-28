using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayUserAntpaasAddtesttagModifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayUserAntpaasAddtesttagModifyModel : AopObject
	{
		/// <summary>
		///     支付宝账户id
		/// </summary>
		[JsonProperty("account_no")]
		public string AccountNo { get; set; }
	}
}