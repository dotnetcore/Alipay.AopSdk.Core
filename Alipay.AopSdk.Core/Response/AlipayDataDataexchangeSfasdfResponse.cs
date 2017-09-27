using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayDataDataexchangeSfasdfResponse.
	/// </summary>
	public class AlipayDataDataexchangeSfasdfResponse : AopResponse
	{
		/// <summary>
		///     dsfagshdj
		/// </summary>
		[JsonProperty("azxfghd")]
		
		public List<string> Azxfghd { get; set; }

		/// <summary>
		///     asghdfsdas阿福故事、
		/// </summary>
		[JsonProperty("gfdhsdasafg")]
		
		public List<string> Gfdhsdasafg { get; set; }

		/// <summary>
		///     fgdhjdsfgh
		/// </summary>
		[JsonProperty("gfhjfdsa")]
		
		public List<string> Gfhjfdsa { get; set; }

		/// <summary>
		///     sdfdhgjfdfsaghjfd
		/// </summary>
		[JsonProperty("ghjfdsafgh")]
		
		public List<string> Ghjfdsafgh { get; set; }

		/// <summary>
		///     sadasff
		/// </summary>
		[JsonProperty("sdvsdv")]
		public string Sdvsdv { get; set; }

		/// <summary>
		///     hysasd
		/// </summary>
		[JsonProperty("wrty")]
		
		public List<AlipayItemGoodsList> Wrty { get; set; }
	}
}