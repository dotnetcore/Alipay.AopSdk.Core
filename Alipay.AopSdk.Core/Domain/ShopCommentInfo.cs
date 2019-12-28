using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ShopCommentInfo Data Structure.
	/// </summary>
	[Serializable]
	public class ShopCommentInfo : AopObject
	{
		/// <summary>
		///     门店评分，评分越高，门店质量越高
		/// </summary>
		[JsonProperty("score")]
		public string Score { get; set; }

		/// <summary>
		///     门店星级，0~5,越高，店铺质量越高
		/// </summary>
		[JsonProperty("star")]
		public string Star { get; set; }
	}
}