using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorDepositQueryResponse.
	/// </summary>
	public class AlipayCommerceCityfacilitatorDepositQueryResponse : AopResponse
	{
		/// <summary>
		///     待圈存明细
		/// </summary>
		[XmlArray("recharge_bills")]
		[XmlArrayItem("recharge_bill")]
		public List<RechargeBill> RechargeBills { get; set; }
	}
}