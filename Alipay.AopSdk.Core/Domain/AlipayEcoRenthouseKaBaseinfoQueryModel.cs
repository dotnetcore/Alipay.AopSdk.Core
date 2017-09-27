using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoRenthouseKaBaseinfoQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoRenthouseKaBaseinfoQueryModel : AopObject
	{
		/// <summary>
		///     kaCode唯一标识
		/// </summary>
		[JsonProperty("ka_code")]
		public string KaCode { get; set; }
	}
}