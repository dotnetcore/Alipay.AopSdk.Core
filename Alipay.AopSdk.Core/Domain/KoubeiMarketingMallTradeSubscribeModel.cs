using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingMallTradeSubscribeModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingMallTradeSubscribeModel : AopObject
	{
		/// <summary>
		///     卡模版id
		/// </summary>
		[JsonProperty("card_template_id")]
		public string CardTemplateId { get; set; }

		/// <summary>
		///     商圈id
		/// </summary>
		[JsonProperty("mall_id")]
		public string MallId { get; set; }
	}
}