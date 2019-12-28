using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     ZhimaCreditAntifraudVerifyResponse.
	/// </summary>
	public class ZhimaCreditAntifraudVerifyResponse : AopResponse
	{
		/// <summary>
		///     芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
		/// </summary>
		[JsonProperty("biz_no")]
		public string BizNo { get; set; }

		/// <summary>
		///     <a href="https://doc.open.alipay.com/docs/doc.htm?treeId=272&articleId=105917&docType=1">验证code列表</a>
		/// </summary>
		[JsonProperty("verify_code")]
		public List<string> VerifyCode { get; set; }
	}
}