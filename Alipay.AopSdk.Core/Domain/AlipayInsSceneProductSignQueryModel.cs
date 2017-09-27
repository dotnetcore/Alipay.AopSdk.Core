using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayInsSceneProductSignQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayInsSceneProductSignQueryModel : AopObject
	{
		/// <summary>
		///     产品编码
		/// </summary>
		[JsonProperty("prod_code")]
		public string ProdCode { get; set; }

		/// <summary>
		///     支付宝会员ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}