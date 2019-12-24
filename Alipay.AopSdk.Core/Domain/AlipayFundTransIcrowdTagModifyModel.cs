using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFundTransIcrowdTagModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransIcrowdTagModifyModel : AopObject
    {
        /// <summary>
        /// 手机号码，与user_id不可同时为空
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 标签编码
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签的值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，与mobile不可同时为空
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
