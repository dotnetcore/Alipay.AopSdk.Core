using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayZdataassetsMetadataResponse.
	/// </summary>
	public class AlipayZdataassetsMetadataResponse : AopResponse
	{
		/// <summary>
		///     用户标签集合
		/// </summary>
		[JsonProperty("result")]
		
		public List<CustomerEntity> Result { get; set; }
	}
}