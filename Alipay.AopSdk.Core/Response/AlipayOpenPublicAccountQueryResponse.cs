using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenPublicAccountQueryResponse.
    /// </summary>
    public class AlipayOpenPublicAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 绑定账户列表
        /// </summary>
        [XmlArray("public_bind_accounts")]
        [XmlArrayItem("std_public_bind_account")]
        public List<StdPublicBindAccount> PublicBindAccounts { get; set; }
    }
}
