using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IcrowdUseContext Data Structure.
    /// </summary>
    [Serializable]
    public class IcrowdUseContext : AopObject
    {
        /// <summary>
        /// 是否开启debug模式
        /// </summary>
        [XmlElement("debug")]
        public bool Debug { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 是否返回延迟信息
        /// </summary>
        [XmlElement("show_delay")]
        public bool ShowDelay { get; set; }
    }
}
