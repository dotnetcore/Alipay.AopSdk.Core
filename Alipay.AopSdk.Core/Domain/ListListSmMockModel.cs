using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ListListSmMockModel Data Structure.
	/// </summary>
	[Serializable]
	public class ListListSmMockModel : AopObject
	{
		/// <summary>
		///     简单模型列表
		/// </summary>
		[JsonProperty("list_simple_model_list")]
		
		public List<SimpleMockModel> ListSimpleModelList { get; set; }
	}
}