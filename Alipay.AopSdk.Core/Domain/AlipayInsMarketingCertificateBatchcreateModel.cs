using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayInsMarketingCertificateBatchcreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayInsMarketingCertificateBatchcreateModel : AopObject
	{
		/// <summary>
		///     批量创建凭证请求
		/// </summary>
		[JsonProperty("ins_create_certificate_requests")]
		
		public List<InsCreateCertificateRequest> InsCreateCertificateRequests { get; set; }
	}
}