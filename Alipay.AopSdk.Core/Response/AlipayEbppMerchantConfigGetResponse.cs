using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEbppMerchantConfigGetResponse.
	/// </summary>
	public class AlipayEbppMerchantConfigGetResponse : AopResponse
	{
		/// <summary>
		///     商户机构配置信息
		/// </summary>
		[XmlArray("inst_configs")]
		[XmlArrayItem("merchant_inst_config")]
		public List<MerchantInstConfig> InstConfigs { get; set; }

		/// <summary>
		///     商户的用户ID
		/// </summary>
		[XmlElement("merchant_user_id")]
		public string MerchantUserId { get; set; }
	}
}