using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsSceneCommandReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommandReceiveModel : AopObject
    {
        /// <summary>
        /// 命令对象
        /// </summary>
        [XmlElement("command")]
        public Command Command { get; set; }
    }
}
