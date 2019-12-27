using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoTextVoiceTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoTextVoiceTransferModel : AopObject
    {
        /// <summary>
        /// 被叫号码
        /// </summary>
        [XmlElement("called_number")]
        public string CalledNumber { get; set; }

        /// <summary>
        /// 内部系统编码，回调消息将回传
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// Tts模板ID
        /// </summary>
        [XmlElement("tts_code")]
        public string TtsCode { get; set; }

        /// <summary>
        /// 替换TTS模板中变量的Map
        /// </summary>
        [XmlElement("tts_param")]
        public string TtsParam { get; set; }
    }
}
