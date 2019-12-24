using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsAutoUserOilQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoUserOilQueryModel : AopObject
    {
        /// <summary>
        /// 车险开发分配，source+scene_type决定了返回的内容
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
