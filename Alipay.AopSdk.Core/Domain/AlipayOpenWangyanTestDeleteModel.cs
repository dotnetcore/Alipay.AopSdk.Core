using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenWangyanTestDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenWangyanTestDeleteModel : AopObject
	{
		/// <summary>
		///     1
		/// </summary>
		[JsonProperty("aaa")]
		public string Aaa { get; set; }

		/// <summary>
		///     2
		/// </summary>
		[JsonProperty("user_name")]
		public string UserName { get; set; }
	}
}