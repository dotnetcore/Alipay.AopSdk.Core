using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMicropayOrderDirectPayResponse.
	/// </summary>
	public class AlipayMicropayOrderDirectPayResponse : AopResponse
	{
		/// <summary>
		///     单笔直接支付返回结果
		/// </summary>
		[XmlElement("single_pay_detail")]
		public SinglePayDetail SinglePayDetail { get; set; }
	}
}