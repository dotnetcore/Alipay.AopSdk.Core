using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ZhimaMerchantTestPracticeModel Data Structure.
	/// </summary>
	[Serializable]
	public class ZhimaMerchantTestPracticeModel : AopObject
	{
		/// <summary>
		///     a d
		/// </summary>
		[JsonProperty("add")]
		
		public List<string> Add { get; set; }

		/// <summary>
		///     zzz
		/// </summary>
		[JsonProperty("xxxx")]
		public XXXXsdasdasd Xxxx { get; set; }
	}
}