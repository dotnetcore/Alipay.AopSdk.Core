using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayUserAccountUseridBatchqueryResponse.
	/// </summary>
	public class AlipayUserAccountUseridBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     用户列表
		/// </summary>
		[XmlArray("user_id_list")]
		[XmlArrayItem("string")]
		public List<string> UserIdList { get; set; }
	}
}