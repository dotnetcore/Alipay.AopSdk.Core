using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KeyanColumn Data Structure.
	/// </summary>
	[Serializable]
	public class KeyanColumn : AopObject
	{
		/// <summary>
		///     密码
		/// </summary>
		[JsonProperty("password")]
		public string Password { get; set; }
	}
}