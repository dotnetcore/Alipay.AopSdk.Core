using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UserDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserDetailInfo : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用户其他详细信息列表，比如商户或者其他平台的信息。
        /// </summary>
        [XmlArray("ext_profile_list")]
        [XmlArrayItem("user_profile_detail")]
        public List<UserProfileDetail> ExtProfileList { get; set; }
    }
}
