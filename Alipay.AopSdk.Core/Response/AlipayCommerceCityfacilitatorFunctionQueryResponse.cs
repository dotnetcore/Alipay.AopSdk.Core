using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorFunctionQueryResponse.
	/// </summary>
	public class AlipayCommerceCityfacilitatorFunctionQueryResponse : AopResponse
	{
		/// <summary>
		///     支持的功能列表
		/// </summary>
		[XmlArray("functions")]
		[XmlArrayItem("support_function")]
		public List<SupportFunction> Functions { get; set; }
	}
}