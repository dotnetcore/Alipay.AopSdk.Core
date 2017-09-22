using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceLotteryTypelistQueryResponse.
	/// </summary>
	public class AlipayCommerceLotteryTypelistQueryResponse : AopResponse
	{
		/// <summary>
		///     彩票系统支持的可用于赠送的彩种类型列表
		/// </summary>
		[XmlArray("results")]
		[XmlArrayItem("lottery_type")]
		public List<LotteryType> Results { get; set; }

		/// <summary>
		///     彩票系统支持的可用于赠送的彩种个数
		/// </summary>
		[XmlElement("total_result")]
		public long TotalResult { get; set; }
	}
}