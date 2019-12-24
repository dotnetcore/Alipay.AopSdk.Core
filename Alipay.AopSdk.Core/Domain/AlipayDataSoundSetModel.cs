using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataSoundSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataSoundSetModel : AopObject
    {
        /// <summary>
        /// 应用token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用秘钥
        /// </summary>
        [XmlElement("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 音量
        /// </summary>
        [XmlElement("voice")]
        public long Voice { get; set; }

        /// <summary>
        /// 蜂鸣器
        /// </summary>
        [XmlElement("voice_type")]
        public string VoiceType { get; set; }
    }
}
