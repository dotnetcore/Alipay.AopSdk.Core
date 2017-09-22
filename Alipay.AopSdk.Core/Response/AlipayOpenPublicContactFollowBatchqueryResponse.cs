using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicContactFollowBatchqueryResponse.
	/// </summary>
	public class AlipayOpenPublicContactFollowBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     联系人关注者列表
		/// </summary>
		[XmlArray("contact_follow_list")]
		[XmlArrayItem("contact_follower")]
		public List<ContactFollower> ContactFollowList { get; set; }
	}
}