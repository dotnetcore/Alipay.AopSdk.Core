using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
		[XmlArray("cm_list")]
		[XmlArrayItem("old_complext_mock_model")]
		public List<OldComplextMockModel> CmList { get; set; }
	}
}