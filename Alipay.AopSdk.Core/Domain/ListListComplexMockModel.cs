using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ListListComplexMockModel Data Structure.
	/// </summary>
	[Serializable]
	public class ListListComplexMockModel : AopObject
	{
		/// <summary>
		///     复杂对象list
		/// </summary>
		[JsonProperty("cm_list")]
		
		public List<ComplextMockModel> CmList { get; set; }
	}
}