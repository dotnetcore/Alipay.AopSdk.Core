using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdOfflineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdOfflineResponse : AopResponse
    {
        /// <summary>
        /// 操作成功外部ID列表
        /// </summary>
        [XmlArray("success_id_list")]
        [XmlArrayItem("string")]
        public List<string> SuccessIdList { get; set; }
    }
}
