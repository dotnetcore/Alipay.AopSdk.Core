using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiCraftsmanDataWorkCreateResponse.
	/// </summary>
	public class KoubeiCraftsmanDataWorkCreateResponse : AopResponse
	{
		/// <summary>
		///     作品id
		/// </summary>
		[JsonProperty("works")]
		
		public List<CraftsmanWorkOutIdOpenModel> Works { get; set; }
	}
}