using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenAppLingqierwuLingqierquQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenAppLingqierwuLingqierquQueryModel : AopObject
	{
		/// <summary>
		///     12
		/// </summary>
		[JsonProperty("test")]
		
		public List<string> Test { get; set; }
	}
}