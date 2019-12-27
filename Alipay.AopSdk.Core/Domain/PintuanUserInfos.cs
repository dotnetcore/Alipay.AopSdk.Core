using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PintuanUserInfos Data Structure.
    /// </summary>
    [Serializable]
    public class PintuanUserInfos : AopObject
    {
        /// <summary>
        /// 拼团用户信息列表
        /// </summary>
        [XmlElement("pintuan_user_info_list")]
        public PintuanUserInfo PintuanUserInfoList { get; set; }
    }
}
