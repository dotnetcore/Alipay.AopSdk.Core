using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdUserbalanceOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdUserbalanceOnlineModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 投放账户id列表
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("number")]
        public List<long> UserIdList { get; set; }
    }
}
