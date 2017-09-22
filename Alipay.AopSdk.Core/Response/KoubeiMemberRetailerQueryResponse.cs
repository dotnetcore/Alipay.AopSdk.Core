using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMemberRetailerQueryResponse.
	/// </summary>
	public class KoubeiMemberRetailerQueryResponse : AopResponse
	{
		/// <summary>
		///     零售商信息列表
		/// </summary>
		[XmlArray("retailer_list")]
		[XmlArrayItem("retailer")]
		public List<Retailer> RetailerList { get; set; }
	}
}