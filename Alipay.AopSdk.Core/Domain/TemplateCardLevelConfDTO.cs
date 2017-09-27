using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     TemplateCardLevelConfDTO Data Structure.
	/// </summary>
	[Serializable]
	public class TemplateCardLevelConfDTO : AopObject
	{
		/// <summary>
		///     会员级别 该级别和开卡接口中的levle要一致
		/// </summary>
		[JsonProperty("level")]
		public string Level { get; set; }

		/// <summary>
		///     会员级别描述
		/// </summary>
		[JsonProperty("level_desc")]
		public string LevelDesc { get; set; }

		/// <summary>
		///     会员级别对应icon， 通过接口（alipay.offline.material.image.upload）上传图片
		/// </summary>
		[JsonProperty("level_icon")]
		public string LevelIcon { get; set; }

		/// <summary>
		///     会员级别显示名称
		/// </summary>
		[JsonProperty("level_show_name")]
		public string LevelShowName { get; set; }
	}
}