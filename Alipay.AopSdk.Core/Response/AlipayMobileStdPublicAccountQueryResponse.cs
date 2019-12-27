using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMobileStdPublicAccountQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 绑定账户列表
        /// </summary>
        [XmlArray("public_bind_accounts")]
        [XmlArrayItem("public_bind_account")]
        public List<PublicBindAccount> PublicBindAccounts { get; set; }
    }
}
