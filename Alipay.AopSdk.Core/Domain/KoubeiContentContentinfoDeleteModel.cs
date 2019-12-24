using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiContentContentinfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiContentContentinfoDeleteModel : AopObject
    {
        /// <summary>
        /// 口碑端内容唯一id，必填
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
