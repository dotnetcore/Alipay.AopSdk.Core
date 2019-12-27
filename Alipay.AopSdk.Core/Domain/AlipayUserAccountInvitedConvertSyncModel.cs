using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserAccountInvitedConvertSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountInvitedConvertSyncModel : AopObject
    {
        /// <summary>
        /// 转化标签
        /// </summary>
        [XmlElement("convert_tag")]
        public string ConvertTag { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
