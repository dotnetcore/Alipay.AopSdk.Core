using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserMemberSceneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberSceneQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 场景名称。  支持的场景：  COLLEGE_LIFE（大学生活）
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
