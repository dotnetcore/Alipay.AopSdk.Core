using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     DishRecommend Data Structure.
	/// </summary>
	[Serializable]
	public class DishRecommend : AopObject
	{
		/// <summary>
		///     购买可能性/商品热度得分
		/// </summary>
		[JsonProperty("buy_posibility")]
		public long BuyPosibility { get; set; }

		/// <summary>
		///     菜品ID
		/// </summary>
		[JsonProperty("dish_id")]
		public string DishId { get; set; }

		/// <summary>
		///     菜品名称
		/// </summary>
		[JsonProperty("dish_name")]
		public string DishName { get; set; }
	}
}