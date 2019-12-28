using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     PaymentAbilityPostbackResponse Data Structure.
	/// </summary>
	[Serializable]
	public class PaymentAbilityPostbackResponse : AopObject
	{
		/// <summary>
		///     错误的订单信息
		/// </summary>
		[JsonProperty("error_order")]
		public string ErrorOrder { get; set; }

		/// <summary>
		///     成功的订单列表,逗号分隔
		/// </summary>
		[JsonProperty("order_ids")]
		public string OrderIds { get; set; }
	}
}