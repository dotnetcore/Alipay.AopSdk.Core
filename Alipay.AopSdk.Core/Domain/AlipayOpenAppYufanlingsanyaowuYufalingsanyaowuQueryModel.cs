using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryModel : AopObject
	{
		/// <summary>
		///     省份编码，国标码
		/// </summary>
		[JsonProperty("province_code")]
		
		public List<string> ProvinceCode { get; set; }
	}
}