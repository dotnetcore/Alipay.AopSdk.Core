using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenAppMembersQueryResponse.
    /// </summary>
    public class AlipayOpenAppMembersQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序成员模型
        /// </summary>
        [XmlArray("app_member_info_list")]
        [XmlArrayItem("app_member_info")]
        public List<AppMemberInfo> AppMemberInfoList { get; set; }
    }
}
