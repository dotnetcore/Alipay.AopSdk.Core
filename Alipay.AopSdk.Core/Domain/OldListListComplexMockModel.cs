using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     OldListListComplexMockModel Data Structure.
	/// </summary>
	[Serializable]
	public class OldListListComplexMockModel : AopObject
	{
		/// <summary>
		///     复杂模型list
		/// </summary>
		[JsonProperty("cm_list")]
		
		public List<OldComplextMockModel> CmList { get; set; }
	}
}