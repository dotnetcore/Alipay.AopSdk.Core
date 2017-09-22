using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcapiprodDrawndnFeerecordQueryResponse.
	/// </summary>
	public class AlipayEcapiprodDrawndnFeerecordQueryResponse : AopResponse
	{
		/// <summary>
		///     费用交易流水
		/// </summary>
		[XmlArray("fee_records")]
		[XmlArrayItem("fee_records")]
		public List<FeeRecords> FeeRecords { get; set; }

		/// <summary>
		///     唯一标识这次请求
		/// </summary>
		[XmlElement("request_id")]
		public string RequestId { get; set; }
	}
}