using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CommentOpenModel Data Structure.
	/// </summary>
	[Serializable]
	public class CommentOpenModel : AopObject
	{
		/// <summary>
		///     口碑评价id
		/// </summary>
		[JsonProperty("comment_id")]
		public string CommentId { get; set; }

		/// <summary>
		///     评价发表时间
		/// </summary>
		[JsonProperty("comment_publish_time")]
		public string CommentPublishTime { get; set; }

		/// <summary>
		///     评价内容，不超过2000字，不区分中英文
		/// </summary>
		[JsonProperty("content")]
		public string Content { get; set; }

		/// <summary>
		///     评价关联的手艺人id
		/// </summary>
		[JsonProperty("craftsman_id")]
		public string CraftsmanId { get; set; }

		/// <summary>
		///     评价上传图片，一条评价最多9张图片
		/// </summary>
		[JsonProperty("images")]
		
		public List<string> Images { get; set; }

		/// <summary>
		///     评价回复
		/// </summary>
		[JsonProperty("reply")]
		public CommentReplyOpenModel Reply { get; set; }

		/// <summary>
		///     评分，1-5分，1分最低，5分最高，均为整数
		/// </summary>
		[JsonProperty("score")]
		public long Score { get; set; }

		/// <summary>
		///     评价对应的门店id
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }
	}
}