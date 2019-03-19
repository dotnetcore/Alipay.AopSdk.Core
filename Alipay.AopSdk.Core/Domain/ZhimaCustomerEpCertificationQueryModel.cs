using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ZhimaCustomerCertificationQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class ZhimaCustomerEpCertificationQueryModel : AopObject
	{
		/// <summary>
		///     一次认证的唯一标识,在商户调用认证初始化接口的时候获取
		/// </summary>
		[JsonProperty("biz_no")]
		public string BizNo { get; set; }
	}
}