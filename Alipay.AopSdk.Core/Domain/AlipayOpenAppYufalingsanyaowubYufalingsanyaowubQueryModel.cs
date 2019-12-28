using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel : AopObject
	{
		/// <summary>
		///     yufaa
		/// </summary>
		[JsonProperty("yufaa")]
		public string Yufaa { get; set; }
	}
}