using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceLotteryPresentlistQueryResponse.
	/// </summary>
	public class AlipayCommerceLotteryPresentlistQueryResponse : AopResponse
	{
		/// <summary>
		///     列表内容
		/// </summary>
		[XmlArray("results")]
		[XmlArrayItem("lottery_present")]
		public List<LotteryPresent> Results { get; set; }

		/// <summary>
		///     返回的列表的大小
		/// </summary>
		[XmlElement("total_result")]
		public long TotalResult { get; set; }
	}
}