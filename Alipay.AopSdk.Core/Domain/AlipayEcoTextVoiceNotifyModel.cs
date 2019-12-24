using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoTextVoiceNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoTextVoiceNotifyModel : AopObject
    {
        /// <summary>
        /// 语音回调列表
        /// </summary>
        [XmlArray("callbacks")]
        [XmlArrayItem("spi_voice_callback")]
        public List<SpiVoiceCallback> Callbacks { get; set; }
    }
}
