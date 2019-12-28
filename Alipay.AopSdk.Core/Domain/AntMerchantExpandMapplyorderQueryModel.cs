using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AntMerchantExpandMapplyorderQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AntMerchantExpandMapplyorderQueryModel : AopObject
	{
		/// <summary>
		///     支付宝端商户入驻申请单据号
		/// </summary>
		[JsonProperty("order_no")]
		public string OrderNo { get; set; }
	}
}