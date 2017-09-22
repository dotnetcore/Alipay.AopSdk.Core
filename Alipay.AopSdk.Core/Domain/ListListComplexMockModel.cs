using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
		[XmlArray("cm_list")]
		[XmlArrayItem("complext_mock_model")]
		public List<ComplextMockModel> CmList { get; set; }
	}
}