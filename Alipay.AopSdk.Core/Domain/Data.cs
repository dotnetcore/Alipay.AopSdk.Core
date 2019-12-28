using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     Data Data Structure.
	/// </summary>
	[Serializable]
	public class Data : AopObject
	{
		/// <summary>
		///     用户id列表
		/// </summary>
		[JsonProperty("user_id_list")]
		
		public List<string> UserIdList { get; set; }
	}
}