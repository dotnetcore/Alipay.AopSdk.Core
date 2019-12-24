using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiContentContentcountSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiContentContentcountSetModel : AopObject
    {
        /// <summary>
        /// 口碑端内容唯一id，必填
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 数字
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
