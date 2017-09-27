using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ItemInfo Data Structure.
	/// </summary>
	[Serializable]
	public class ItemInfo : AopObject
	{
		/// <summary>
		///     券适用的单品码列表  最少配置1个单品码  最多配置500个单品码
		/// </summary>
		[JsonProperty("item_ids")]
		
		public List<string> ItemIds { get; set; }

		/// <summary>
		///     单品图片列表  单品图片不能超过3张
		/// </summary>
		[JsonProperty("item_imgs")]
		
		public List<string> ItemImgs { get; set; }

		/// <summary>
		///     单品券详细介绍跳转链接
		/// </summary>
		[JsonProperty("item_link")]
		public string ItemLink { get; set; }

		/// <summary>
		///     单品名称
		/// </summary>
		[JsonProperty("item_name")]
		public string ItemName { get; set; }

		/// <summary>
		///     单品券说明
		/// </summary>
		[JsonProperty("item_text")]
		public string ItemText { get; set; }

		/// <summary>
		///     最高优惠商品件数
		/// </summary>
		[JsonProperty("max_discount_num")]
		public string MaxDiscountNum { get; set; }

		/// <summary>
		///     最低购买商品件数
		/// </summary>
		[JsonProperty("min_consume_num")]
		public string MinConsumeNum { get; set; }

		/// <summary>
		///     单品的原价，单位元  必须为合法金额类型字符串，如9.99
		/// </summary>
		[JsonProperty("original_price")]
		public string OriginalPrice { get; set; }

		/// <summary>
		///     券适用SKU的最低消费金额门槛  如券适用A,B两个SKU，该字段设置的值为100，则订单中购买A,B两个SKU的合计金额需大于100元才可用券
		/// </summary>
		[JsonProperty("sku_min_consume")]
		public string SkuMinConsume { get; set; }
	}
}