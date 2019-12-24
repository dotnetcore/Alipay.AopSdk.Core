using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdUserbalanceOfflineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdUserbalanceOfflineResponse : AopResponse
    {
        /// <summary>
        /// 操作成功投放账户id列表
        /// </summary>
        [XmlArray("success_user_id_list")]
        [XmlArrayItem("string")]
        public List<string> SuccessUserIdList { get; set; }
    }
}
