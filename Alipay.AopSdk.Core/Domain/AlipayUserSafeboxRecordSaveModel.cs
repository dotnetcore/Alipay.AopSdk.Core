using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserSafeboxRecordSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSafeboxRecordSaveModel : AopObject
    {
        /// <summary>
        /// 用钢铁匣公钥加密后的内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 用于加密传输标题和内容的钢铁匣密钥版本。默认值1
        /// </summary>
        [XmlElement("key_version")]
        public string KeyVersion { get; set; }

        /// <summary>
        /// 钢铁匣为接入方提供的应用场景码。一个APPID可以对应多个场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 用钢铁匣公钥加密后的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 唯一id，用作幂等。每一个唯一id只能对应一条记录。同一个场景码下，对应多个唯一id
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
