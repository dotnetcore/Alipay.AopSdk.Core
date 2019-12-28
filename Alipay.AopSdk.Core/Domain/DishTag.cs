using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     DishTag Data Structure.
	/// </summary>
	[Serializable]
	public class DishTag : AopObject
	{
		/// <summary>
		///     标签类型 : 如"菜属性"，"菜推荐"
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		///     标签值：如"重辣","中辣","招牌菜","创意菜"
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}