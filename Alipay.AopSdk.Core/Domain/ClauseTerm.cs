using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ClauseTerm Data Structure.
	/// </summary>
	[Serializable]
	public class ClauseTerm : AopObject
	{
		/// <summary>
		///     说明描述内容
		/// </summary>
		[JsonProperty("descriptions")]
		
		public List<string> Descriptions { get; set; }

		/// <summary>
		///     说明title
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}