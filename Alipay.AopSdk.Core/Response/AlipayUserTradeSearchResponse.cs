using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayUserTradeSearchResponse.
	/// </summary>
	public class AlipayUserTradeSearchResponse : AopResponse
	{
		/// <summary>
		///     总页数
		/// </summary>
		[XmlElement("total_pages")]
		public string TotalPages { get; set; }

		/// <summary>
		///     总记录数
		/// </summary>
		[XmlElement("total_results")]
		public string TotalResults { get; set; }

		/// <summary>
		///     交易记录列表
		/// </summary>
		[XmlArray("trade_records")]
		[XmlArrayItem("trade_record")]
		public List<TradeRecord> TradeRecords { get; set; }
	}
}