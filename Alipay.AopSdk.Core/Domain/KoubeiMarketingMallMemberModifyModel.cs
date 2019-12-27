using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingMallMemberModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingMallMemberModifyModel : AopObject
    {
        /// <summary>
        /// 需要修改的最新卡信息
        /// </summary>
        [XmlElement("card_info")]
        public MallCardUpdate CardInfo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
